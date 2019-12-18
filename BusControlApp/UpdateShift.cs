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
    public partial class UpdateShift : Form
    {
        private int shiftId;

        public UpdateShift(int shiftId)
        {
            this.shiftId = shiftId;
            InitializeComponent();
        }

        private void LoadAllRoutes()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

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

            connection.Close();
        }
        private void LoadAllBuses()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

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

            connection.Close();

        }
        private void LoadAllDrivers()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

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
            connection.Close();

        }
        private void LoadScheduleNumber(int scheduleNumber)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

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

            connection.Close();

        }

        private void GetLayUp()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT * FROM BusLayUp WHERE lay_up_shift_id = @shiftId";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = shiftId;

            command.Parameters.Add(shiftIdParam);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string layUpText = (string) reader.GetValue(4);

                this.layUpInfo.Text = layUpText;
            }

            connection.Close();
        }

        private void SetShiftInformation()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT * FROM WorkShift WHERE shift_id = @shiftId";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = shiftId;

            command.Parameters.Add(shiftIdParam);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            int busId = (int)reader.GetValue(2);
            int shiftRouteId = (int)reader.GetValue(3);
            int shiftScheduleNumber = (int)reader.GetValue(4);

            busInputField.SelectedValue = busId;
            routeInputField.SelectedValue = shiftRouteId;
            scheduleInputField.SelectedValue = shiftScheduleNumber;

            if (!reader.IsDBNull(5))
            {
                shiftEarningsInputField.Text = reader.GetValue(5).ToString();
            }
            if (!reader.IsDBNull(7))
            {
                startFuelInputField.Text = reader.GetValue(7).ToString();
            }
            if (!reader.IsDBNull(8))
            {
                endFuelInputField.Text = reader.GetValue(8).ToString();
            }

            reader.Close();

            // Получаем водителя

            string getDriverQuery = "SELECT driver_id FROM ShiftDrivers WHERE shift_id = @shiftId";

            SqlCommand getDriverCommand = new SqlCommand(getDriverQuery, connection);

            SqlParameter driverShiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);
            driverShiftIdParam.Value = shiftId;
            getDriverCommand.Parameters.Add(driverShiftIdParam);

            reader = getDriverCommand.ExecuteReader();

            reader.Read();

            int driverId = (int)reader.GetValue(0);

            driverInputField.SelectedValue = driverId;

            connection.Close();

        }

        private void GetLinearControl()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string SQLQuery = "SELECT control_info FROM ControlInfo WHERE control_shift_id = @shiftId";

            SqlCommand command = new SqlCommand(SQLQuery, connection);

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = shiftId;

            command.Parameters.Add(shiftIdParam);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                this.linearControlInputField.Text = (string)reader.GetValue(0);
            }

            connection.Close();

        }

        private void UpdateShift_Load(object sender, EventArgs e)
        {
            LoadAllBuses();
            LoadAllDrivers();
            LoadAllRoutes();

            SetShiftInformation();

            GetLayUp();

            GetLinearControl();
        }

        private void RouteInputField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (routeInputField.SelectedValue == null) return;
            LoadScheduleNumber((int)routeInputField.SelectedValue);
        }

        private void UpdateLayUp(int shiftId)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string updateLayUpQuery =
                    "UPDATE BusLayUp SET lay_up_info = @layUpText " +
                    "WHERE lay_up_shift_id = @shiftId";

            SqlCommand command = new SqlCommand(updateLayUpQuery, connection);

            string layUpInfo = this.layUpInfo.Text;

            SqlParameter layUpTextParam = new SqlParameter("@layUpText", SqlDbType.VarChar);

            layUpTextParam.Value = layUpInfo;

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = this.shiftId;

            command.Parameters.Add(shiftIdParam);
            command.Parameters.Add(layUpTextParam);

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void InsertLayUp(int shiftId)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string insertLayUpQuery =
                    "INSERT INTO BusLayUp(lay_up_shift_id, lay_up_info)" +
                    "VALUES(@shiftId, @layUpText)";

            SqlCommand command = new SqlCommand(insertLayUpQuery, connection);

            string layUpInfo = this.layUpInfo.Text;

            SqlParameter layUpTextParam = new SqlParameter("@layUpText", SqlDbType.VarChar);

            layUpTextParam.Value = layUpInfo;

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = this.shiftId;

            command.Parameters.Add(shiftIdParam);
            command.Parameters.Add(layUpTextParam);

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void UpdateLinearControl()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string updateControlQuery =
                    "UPDATE ControlInfo SET control_info = @controlText " +
                    "WHERE control_shift_id = @shiftId";

            SqlCommand command = new SqlCommand(updateControlQuery, connection);

            string controlInfo = this.linearControlInputField.Text;

            SqlParameter controlTextParam = new SqlParameter("@controlText", SqlDbType.VarChar);

            controlTextParam.Value = controlInfo;

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = this.shiftId;

            command.Parameters.Add(controlTextParam);
            command.Parameters.Add(shiftIdParam);

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void InsertLinearControl()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string updateControlQuery =
                    "INSERT INTO ControlInfo(control_shift_id, control_info)" +
                    "VALUES (@shiftId, @controlInfo)";

            SqlCommand command = new SqlCommand(updateControlQuery, connection);

            string controlInfo = this.linearControlInputField.Text;

            SqlParameter controlTextParam = new SqlParameter("@controlInfo", SqlDbType.VarChar);

            controlTextParam.Value = controlInfo;

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = this.shiftId;

            command.Parameters.Add(controlTextParam);
            command.Parameters.Add(shiftIdParam);

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void SaveUpdatedShiftButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string queryTestLayUp = "SELECT * FROM BusLayUp WHERE lay_up_shift_id = @shiftId";

            SqlCommand testLayUp = new SqlCommand(queryTestLayUp, connection);

            SqlParameter shiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            shiftIdParam.Value = this.shiftId;

            testLayUp.Parameters.Add(shiftIdParam);

            SqlDataReader reader = testLayUp.ExecuteReader();
            

            if (reader.HasRows)
            {
                reader.Close();
                UpdateLayUp(shiftId);
            }
            else
            {
                reader.Close();
                InsertLayUp(shiftId);
            }

            reader.Close();

            string controlTestQuery = "SELECT * FROM ControlInfo WHERE control_shift_id = @shiftId";

            SqlCommand testControl = new SqlCommand(controlTestQuery, connection);

            SqlParameter controlShiftIdParam = new SqlParameter("@shiftId", SqlDbType.Int);

            controlShiftIdParam.Value = this.shiftId;

            testControl.Parameters.Add(controlShiftIdParam);

            reader = testControl.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                UpdateLinearControl();
            }
            else
            {
                reader.Close();
                InsertLinearControl();
            }
            connection.Close();
            this.Close();
        }
    }
}
