using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusControlApp
{
    public partial class SelectActionPage : Form
    {
        public int userRole;

        public SelectActionPage(int userRole)
        {
            this.userRole = userRole;

            InitializeComponent();
        }

        private void SelectActionPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void showBusesBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = (MainPage)this.MdiParent;

            mainPage.busesPage = new BusesPage(userRole);

            mainPage.busesPage.MdiParent = this.MdiParent;

            this.MdiParent.ClientSize = mainPage.busesPage.Size;

            mainPage.busesPage.Show();

            this.Close();
        }

        private void ShowShiftTableBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = (MainPage)this.MdiParent;

            mainPage.shiftPage = new ShiftPage(userRole);

            mainPage.shiftPage.MdiParent = this.MdiParent;

            this.MdiParent.ClientSize = mainPage.shiftPage.Size;

            mainPage.shiftPage.Show();

            this.Close();
        }
    }
}
