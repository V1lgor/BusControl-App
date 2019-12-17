using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace BusControlApp
{
    public partial class AddShift : Form
    {
        private SqlConnection connection;
        public AddShift()
        {
            InitializeComponent();
        }

        private void LoadAllRoutes()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT route_id, route_number FROM BusRoute";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            routeInputField.DisplayMember = "route_number";
            routeInputField.ValueMember = "route_id";

            routeInputField.DataSource = ds.Tables[0];

            routeInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            routeInputField.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadAllBuses()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT bus_id, bus_number FROM Bus";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            busInputField.ValueMember = "bus_id";
            busInputField.DisplayMember = "bus_number";

            busInputField.DataSource = ds.Tables[0];

            busInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            busInputField.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void LoadAllDrivers()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT person_id, person_last_name + ' ' + person_first_name + ' ' + person_patronymic AS fullname " +
                "FROM Staff JOIN Driver ON person_id = driver_id";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            driverInputField.DisplayMember = "fullname";
            driverInputField.ValueMember = "person_id";

            driverInputField.DataSource = ds.Tables[0];

            driverInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            driverInputField.AutoCompleteSource = AutoCompleteSource.ListItems;

            
        }
        private void LoadScheduleNumber(int scheduleNumber)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT DISTINCT schedule_number FROM BusSchedule WHERE schedule_route_id = @route";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter routeNumber = new SqlParameter("@route", SqlDbType.Int);

            routeNumber.Value = scheduleNumber;

            command.Parameters.Add(routeNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            scheduleInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            scheduleInputField.AutoCompleteSource = AutoCompleteSource.ListItems;

            scheduleInputField.DisplayMember = "schedule_number";
            scheduleInputField.ValueMember = "schedule_number";

            scheduleInputField.DataSource = ds.Tables[0];
            
        }
        private void AddShift_Load(object sender, EventArgs e)
        {
            LoadAllRoutes();
            LoadAllDrivers();
            LoadAllBuses();
        }

        private void RouteInputField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (routeInputField.SelectedValue == null) return;
            LoadScheduleNumber((int)routeInputField.SelectedValue);
        }

        private void AddShiftAcceptBtn_Click(object sender, EventArgs e)
        {
            int shiftRouteId = (int) routeInputField.SelectedValue;
            int scheduleId = (int)scheduleInputField.SelectedValue;
            int driverId = (int)driverInputField.SelectedValue;
            int busId = (int)busInputField.SelectedValue;

            Console.WriteLine($"{shiftRouteId} {scheduleId} {driverId} {busId}");

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery =
                "INSERT INTO WorkShift(shift_route_id, shift_schedule_number, shift_bus_id)" +
                "VALUES(@shiftRouteId, @scheduleId, @busId);" +
                "SELECT CAST(SCOPE_IDENTITY() AS INT)";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter shiftRouteParam = new SqlParameter("@shiftRouteId", SqlDbType.Int);
            SqlParameter shiftScheduleParam = new SqlParameter("@scheduleId", SqlDbType.Int);
            SqlParameter shiftBusParam = new SqlParameter("@busId", SqlDbType.Int);

            shiftRouteParam.Value = shiftRouteId;
            shiftScheduleParam.Value = scheduleId;
            shiftBusParam.Value = busId;

            command.Parameters.Add(shiftRouteParam);
            command.Parameters.Add(shiftScheduleParam);

            command.Parameters.Add(shiftBusParam);

            int shiftId = (int)command.ExecuteScalar();

            command.CommandText = "INSERT INTO ShiftDrivers VALUES(@shiftId, @driverId)";

            SqlParameter shiftDriverParam = new SqlParameter("@driverId", SqlDbType.Int);
            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftDriverParam.Value = driverId;
            shiftIdParam.Value = shiftId;

            command.Parameters.Add(shiftDriverParam);
            command.Parameters.Add(shiftIdParam);

            command.ExecuteNonQuery();

            this.Close();
        }
    }
}
