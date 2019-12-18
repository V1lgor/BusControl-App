using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace BusControlApp
{
    public partial class UpdateBus : Form
    {
        private int busId;

        public UpdateBus(int busId)
        {
            this.busId = busId;
            InitializeComponent();
        }
        private void GetManufacturerList()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            SqlCommand selectManufacturers = new SqlCommand("SELECT * FROM Manufacturer", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(selectManufacturers);

            DataSet manufacturers = new DataSet();

            adapter.Fill(manufacturers);

            manufInputField.DisplayMember = "manuf_title";
            manufInputField.ValueMember = "manuf_id";

            this.manufInputField.DataSource = manufacturers.Tables[0];

            connection.Close();
        }

        private void GetCompanyList()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            SqlCommand selectCompanyList = new SqlCommand("SELECT company_id, company_name FROM Company", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(selectCompanyList);

            DataSet companyList = new DataSet();

            adapter.Fill(companyList);

            companyInputField.DisplayMember = "company_name";
            companyInputField.ValueMember = "company_id";

            this.companyInputField.DataSource = companyList.Tables[0];

            connection.Close();
        }

        private void GetBusLicenseList()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            SqlCommand selectLicenseList =
                new SqlCommand("SELECT * FROM DriverLicenseCategory WHERE category = 'D' OR category = 'DE'",
                               connection);

            SqlDataAdapter adapter = new SqlDataAdapter(selectLicenseList);

            DataSet licenseList = new DataSet();

            adapter.Fill(licenseList);

            licenseInputField.DisplayMember = "category";
            licenseInputField.ValueMember = "category_id";

            this.licenseInputField.DataSource = licenseList.Tables[0];

            connection.Close();
        }

        private void UpdateBus_Load(object sender, EventArgs e)
        {
            GetManufacturerList();
            GetCompanyList();
            GetBusLicenseList();

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string getBusQuery = "SELECT * FROM Bus WHERE bus_id = @busId";

            SqlCommand command = new SqlCommand(getBusQuery, connection);

            command.Parameters.AddWithValue("@busId", busId);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            this.vinInputField.Text = (string)reader.GetValue(1);
            this.manufInputField.SelectedValue = (int)reader.GetValue(2);
            this.modelInputField.Text = (string)reader.GetValue(3);
            this.prodYearInputField.Text = reader.GetValue(4).ToString();
            this.companyInputField.SelectedValue = (int)reader.GetValue(5);
            this.busNumberInputField.Text = (string)reader.GetValue(6);
            this.garageNumberInputField.Text = reader.GetValue(7).ToString();
            this.mileageInputField.Text = (string)reader.GetValue(8).ToString();
            this.tankVolumeInputField.Text = (string)reader.GetValue(9).ToString();
            this.licenseInputField.SelectedValue = (int)reader.GetValue(10);

            connection.Close();

        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            string VIN = this.vinInputField.Text;
            int manufId = (int)this.manufInputField.SelectedValue;
            string model = this.modelInputField.Text;

            int year = 0;
            bool yearParseResult = Int32.TryParse(this.prodYearInputField.Text, out year);

            if (!yearParseResult)
            {
                MessageBox.Show("Год производства введен некорректно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int companyId = (int)this.companyInputField.SelectedValue;

            string busNumber = this.busNumberInputField.Text;
            string garageNumber = this.garageNumberInputField.Text;

            int mileage = 0;

            bool mileageParseResult = Int32.TryParse(this.mileageInputField.Text, out mileage);

            if (!mileageParseResult)
            {
                MessageBox.Show("Пробег автобуса введен некорректно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tankVolume = 0;

            bool tankVolumeParseResult = Int32.TryParse(this.tankVolumeInputField.Text, out tankVolume);

            if (!tankVolumeParseResult)
            {
                MessageBox.Show("Объем топливного бака автобуса введен некорректно", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int licenseCategoryId = (int)this.licenseInputField.SelectedValue;

            // Inserting values into DB
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string updateBusQuery =
                "UPDATE Bus SET bus_vin = @busVin, bus_manuf_id = @busManuf, " +
                "bus_model = @busModel, bus_production_year = @busProdYear, bus_company_id = @busCompany, " +
                "bus_number = @busNumber, bus_garage_number = @busGarageNumber, bus_mileage = @busMileage, " +
                "bus_tank_volume = @busTankVolume, bus_license_category = @busLicense " +
                "WHERE bus_id = @busId";

            SqlCommand command = new SqlCommand(updateBusQuery, connection);

            command.Parameters.AddWithValue("@busVin", VIN);
            command.Parameters.AddWithValue("@busManuf", manufId);
            command.Parameters.AddWithValue("@busModel", model);
            command.Parameters.AddWithValue("@busProdYear", year);
            command.Parameters.AddWithValue("@busCompany", companyId);
            command.Parameters.AddWithValue("@busNumber", busNumber);
            command.Parameters.AddWithValue("@busGarageNumber", garageNumber);
            command.Parameters.AddWithValue("@busMileage", mileage);
            command.Parameters.AddWithValue("@busTankVolume", tankVolume);
            command.Parameters.AddWithValue("@busLicense", licenseCategoryId);
            command.Parameters.AddWithValue("@busId", busId);

            command.ExecuteNonQuery();

            this.Close();
        }
    }
}
