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
    public partial class MainPage : Form
    {
        public BusesPage busesPage;
        public int userRole;

        public MainPage(int userRole)
        {
            this.userRole = userRole;
            InitializeComponent();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (busesPage != null) return;

            busesPage = new BusesPage();

            busesPage.MdiParent = this;

            this.ClientSize = busesPage.Size;

            busesPage.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            SelectActionPage actionPage = new SelectActionPage();

            actionPage.MdiParent = this;

            this.ClientSize = actionPage.Size;

            //actionPage.WindowState = FormWindowState.Maximized;

            actionPage.Show();
        }

        private void MainPage_MdiChildActivate(object sender, EventArgs e)
        {
            Console.WriteLine($"Текущий ребенок: {this.ActiveMdiChild}");

            this.Height += 20;

        }
    }
}
