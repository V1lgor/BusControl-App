using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BusControlApp
{
    public partial class ShiftPage : Form
    {
        private SqlConnection connection;
        public ShiftPage(int userRole)
        {
            // Создаем подключение к БД
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            this.connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();  // Открываем соединение

                Console.WriteLine($"Подключение к базе данных {connection.Database} открыто!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }


            InitializeComponent();
        }

        private void ShiftPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            this.shiftTable.Location = new Point(20, this.shiftTable.Location.Y);
            this.shiftTable.Width = this.ClientRectangle.Width - 40;


            string SQLQuery = 
                "SELECT WorkShift.shift_id, shift_date, route_number, " +
                "shift_schedule_number, bus_number, " +
                "shift_earnings, " +
                "person_last_name + ' ' + SUBSTRING(person_first_name, 1, 1) + '. ' " +
                "                       + SUBSTRING(person_patronymic, 1, 1) + '.' AS 'driver' " +
                "FROM WorkShift JOIN ShiftDrivers " +
                "   ON WorkShift.shift_id = ShiftDrivers.shift_id " +
                "JOIN BusRoute ON shift_route_id = BusRoute.route_id " +
                "JOIN Bus ON shift_bus_id = Bus.bus_id " +
                "JOIN Staff ON ShiftDrivers.driver_id = Staff.person_id";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            shiftTable.Columns["shiftId"].DataPropertyName = "shift_id";
            shiftTable.Columns["shiftDate"].DataPropertyName = "shift_date";
            shiftTable.Columns["shiftRoute"].DataPropertyName = "route_number";
            shiftTable.Columns["shiftScheduleNumber"].DataPropertyName = "shift_schedule_number";
            shiftTable.Columns["shiftBusNumber"].DataPropertyName = "bus_number";
            shiftTable.Columns["shiftEarnings"].DataPropertyName = "shift_earnings";
            shiftTable.Columns["shiftDriver"].DataPropertyName = "driver";


            shiftTable.DataSource = ds.Tables[0];
        }

        private void ShiftPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage parent = (MainPage)this.MdiParent;
            parent.shiftPage = null;
        }

        private void ShiftPage_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("ShiftPage resized");
            this.shiftTable.Width = this.ClientRectangle.Width - 40;
        }

        private void AddShiftBtn_Click(object sender, EventArgs e)
        {
            AddShift addShiftForm = new AddShift();

            addShiftForm.Show();
        }
    }
}
