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
    public partial class AddRepairInfo : Form
    {
        private int busId;

        public AddRepairInfo(int busId)
        {
            this.busId = busId;
            InitializeComponent();
        }

        private void AddRepairInfo_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            string getMechs =
                "SELECT person_last_name + ' ' + person_first_name + ' ' + person_patronymic AS fullname, " +
                "person_id " +
                "FROM Staff JOIN Mechanic ON mech_id = person_id";

            SqlCommand command = new SqlCommand(getMechs, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet mechList = new DataSet();

            adapter.Fill(mechList);

            this.mechInputField.DisplayMember = "fullname";
            this.mechInputField.ValueMember = "person_id";

            this.mechInputField.DataSource = mechList.Tables[0];
        }

        private void btnAcceptRepair_Click(object sender, EventArgs e)
        {
            double repairCost = 0;

            bool costParseResult = Double.TryParse(this.repairCostInputField.Text, out repairCost);

            if (!costParseResult)
            {
                MessageBox.Show("Цена ремонта введена некорректно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string repairInfo = this.repairInfoInputField.Text;

            int mechId = (int) this.mechInputField.SelectedValue;


        }
    }
}
