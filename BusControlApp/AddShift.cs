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

            routeInputField.DataSource = ds.Tables[0];

            routeInputField.DisplayMember = "route_number";
            routeInputField.ValueMember = "route_id";


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

            busInputField.DataSource = ds.Tables[0];

            busInputField.ValueMember = "bus_id";
            busInputField.DisplayMember = "bus_number";

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

            driverInputField.DataSource = ds.Tables[0];

            driverInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            driverInputField.AutoCompleteSource = AutoCompleteSource.ListItems;
            driverInputField.DisplayMember = "fullname";

            
        }
        private void LoadScheduleNumber(int scheduleNumber)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT schedule_number FROM BusSchedule WHERE schedule_route_id = @route";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter routeNumber = new SqlParameter("@route", SqlDbType.Int);

            routeNumber.Value = routeInputField.SelectedValue;

            command.Parameters.Add(routeNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            driverInputField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            driverInputField.AutoCompleteSource = AutoCompleteSource.ListItems;

            driverInputField.DataSource = ds.Tables[0];
            
        }
        private void AddShift_Load(object sender, EventArgs e)
        {
            LoadAllRoutes();
            LoadAllDrivers();
            LoadAllBuses();

        }

        private void RouteInputField_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadScheduleNumber(1);
        }
    }
}
