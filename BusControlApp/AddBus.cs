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
    public partial class AddBus : Form
    {
        public AddBus()
        {
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

        private void AddBus_Load(object sender, EventArgs e)
        {
            GetManufacturerList();
            GetCompanyList();
            GetBusLicenseList();   
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            string VIN = this.vinInputField.Text;
            int manufId = (int) this.manufInputField.SelectedValue;
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

            int licenseCategoryId = (int) this.licenseInputField.SelectedValue;

            // Inserting values into DB
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string insertBusQuery =
                "INSERT INTO Bus(bus_vin, bus_manuf_id, bus_model, bus_production_year, " +
                                "bus_company_id, bus_number, bus_garage_number, bus_mileage, " +
                                "bus_tank_volume, bus_license_category) " +
                "VALUES " +
                "(@busVin, @busManuf, @busModel, @busProdYear, @busCompany, @busNumber, @busGarageNumber," +
                " @busMileage, @busTankVolume, @busLicense)";

            SqlCommand command = new SqlCommand(insertBusQuery, connection);

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

            command.ExecuteNonQuery();

            this.Close();
        }
    }
}
