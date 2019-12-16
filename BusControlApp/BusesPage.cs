using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BusControlApp
{
    public partial class BusesPage : Form
    {
        private SqlConnection connection;

        public BusesPage()
        {
            

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            this.connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                Console.WriteLine($"Подключение к базе данных {connection.Database} открыто!");


            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            InitializeComponent();

            this.addBusBtn.Location = new Point(20, this.addBusBtn.Location.Y);

            Console.WriteLine("Создана форма BusesPage!");
        }



        private void BusesPage_Load(object sender, EventArgs e)
        {
            // Устанавливаем размеры родительской формы
            this.Dock = DockStyle.Fill;
           // this.WindowState = FormWindowState.Maximized;

            // Выполняем запрос к БД

            string SQLQuery = "SELECT * FROM Bus";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLQuery, connection);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            this.dataGridView1.Location = new Point(20, this.dataGridView1.Location.Y);

            this.dataGridView1.Width = this.ClientRectangle.Width - 40;

            dataGridView1.Columns["busId"].DataPropertyName = "bus_id";
            dataGridView1.Columns["busVIN"].DataPropertyName = "bus_VIN";
            dataGridView1.Columns["busManufacturer"].DataPropertyName = "bus_manuf_id";
            dataGridView1.Columns["busModel"].DataPropertyName = "bus_model";
            dataGridView1.Columns["busNumber"].DataPropertyName = "bus_number";
            dataGridView1.Columns["busProductionYear"].DataPropertyName = "bus_production_year";
            dataGridView1.Columns["busCompany"].DataPropertyName = "bus_company_id";
            dataGridView1.Columns["busGarageNumber"].DataPropertyName = "bus_garage_number";
            dataGridView1.Columns["busMileage"].DataPropertyName = "bus_mileage";
            dataGridView1.Columns["busLicenseCategory"].DataPropertyName = "bus_license_category";
            dataGridView1.Columns["busTankVolume"].DataPropertyName = "bus_tank_volume";
            dataGridView1.Columns["busIsWrittenOff"].DataPropertyName = "bus_is_written_off";

            dataGridView1.AutoResizeColumn(1);

            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void BusesPage_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Width = this.ClientRectangle.Width - 40;
        }

        private void busNumberSearchField_TextChanged(object sender, EventArgs e)
        {
            connection.Open();

            

            string SqlQuery = "SELECT * FROM Bus WHERE bus_number LIKE @Number;";

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            SqlParameter busNumber = new SqlParameter("@Number", SqlDbType.VarChar);

            busNumber.Value = this.busNumberSearchField.Text + '%';

            command.CommandText = SqlQuery;
            command.Connection = connection;

            command.Parameters.Add(busNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            connection.Close();
        }
    }
}
