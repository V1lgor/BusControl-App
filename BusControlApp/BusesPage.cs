﻿using System;
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
        // Сохраняем подключение к БД в виде отдельного свойства, чтобы каждый раз не создавать подключение

        public int userRole;

        // Конструктор формы просмотра автобусов
        public BusesPage(int userRole)
        {
            InitializeComponent();  // Отрисовываем форму

            // Насильно выравниваем кнопку "Добавить автобус" по таблице автобусов
            this.addBusButton.Location = new Point(20, this.addBusButton.Location.Y);

            Console.WriteLine("Создана форма BusesPage!");

            this.userRole = userRole;

            this.writeOffBusButton.Enabled = false;
            this.updateBusButton.Enabled = false;
            this.showBusRepairsButton.Enabled = false;
            this.addRepairButton.Enabled = false;
        }

        private void LoadAllBuses()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();

            // Строка запроса к БД
            string SQLQuery = "SELECT * FROM Bus";

            // Создаем адаптер данных для нашего запроса
            SqlDataAdapter adapter = new SqlDataAdapter(SQLQuery, connection);

            // Создаем датасет для нашей таблицы
            DataSet ds = new DataSet();

            // Заполняем созданный датасет данными из адаптера
            adapter.Fill(ds);

            // Задаем позицию и размеры таблицы автобусов
            this.busesTable.Location = new Point(20, this.busesTable.Location.Y);
            this.busesTable.Width = this.ClientRectangle.Width - 40;

            // Задаем для каждого столбца таблицы автобусов на форме название столбца-источника данных
            busesTable.Columns["busId"].DataPropertyName = "bus_id";
            busesTable.Columns["busVIN"].DataPropertyName = "bus_VIN";
            busesTable.Columns["busManufacturer"].DataPropertyName = "bus_manuf_id";
            busesTable.Columns["busModel"].DataPropertyName = "bus_model";
            busesTable.Columns["busNumber"].DataPropertyName = "bus_number";
            busesTable.Columns["busProductionYear"].DataPropertyName = "bus_production_year";
            busesTable.Columns["busCompany"].DataPropertyName = "bus_company_id";
            busesTable.Columns["busGarageNumber"].DataPropertyName = "bus_garage_number";
            busesTable.Columns["busMileage"].DataPropertyName = "bus_mileage";
            busesTable.Columns["busLicenseCategory"].DataPropertyName = "bus_license_category";
            busesTable.Columns["busTankVolume"].DataPropertyName = "bus_tank_volume";
            busesTable.Columns["busIsWrittenOff"].DataPropertyName = "bus_is_written_off";

            // Проходим по всем столбцам таблицы на форме
            foreach (DataGridViewColumn column in busesTable.Columns)
            {
                column.ReadOnly = true; // И задаем им свойство ReadOnly
            }
            // Задаем источник данных для таблицы на форме как 0-ю 
            // (в данном случае еще и единственную) таблицу из датасета
            busesTable.DataSource = ds.Tables[0];

            if (userRole == 2)
            {
                busesTable.Columns["busId"].Visible = false;
                busesTable.Columns["busVIN"].Visible = false;
                busesTable.Columns["busGarageNumber"].Visible = false;
                busesTable.Columns["busTankVolume"].Visible = false;
                busesTable.Columns["busIsWrittenOff"].Visible = false;

                (busesTable.DataSource as DataTable).DefaultView.RowFilter = "[bus_is_written_off] = 'False'";

                this.addBusButton.Visible = false;
                this.updateBusButton.Visible = false;
                this.addRepairButton.Visible = false;
                this.showBusRepairsButton.Visible = false;
                this.writeOffBusButton.Visible = false;
            }

            connection.Close();
        }


        // Событие загрузки формы
        private void BusesPage_Load(object sender, EventArgs e)
        {
            // Заставляем форму растянуться по контейнеру
            this.Dock = DockStyle.Fill;

            LoadAllBuses();
        }

        // Обработчик изменения размеров формы
        private void BusesPage_Resize(object sender, EventArgs e)
        {
            // Каждый раз при изменении размеров формы растягиваем таблицу
            this.busesTable.Width = this.ClientRectangle.Width - 40;
        }

        // Обработка изменения значения в поле поиска автобуса по гос. номеру
        private void busNumberSearchField_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            connection.Open();

            // Запрос на поиск автобусов с похожим госномером. Параметр @number - значение в поле поиска
            string SqlQuery = "SELECT * FROM Bus WHERE bus_number LIKE @Number;";

            // Создаем запрос
            SqlCommand command = new SqlCommand(SqlQuery, connection);

            // Создаем параметр
            SqlParameter busNumber = new SqlParameter("@Number", SqlDbType.VarChar);

            // Присваиваем ему значение
            busNumber.Value = this.busNumberSearchField.Text + '%';

            // Добавляем его к запросу
            command.Parameters.Add(busNumber);

            // Создаем адаптер для этого запроса
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Датасет
            DataSet ds = new DataSet();

            //Заполняем датасет данными из адаптера
            adapter.Fill(ds);

            // Устанавливаем для таблицы автобусов источник
            this.busesTable.DataSource = ds.Tables[0];
            if (userRole == 2)
                (busesTable.DataSource as DataTable).DefaultView.RowFilter = "[bus_is_written_off] = 'False'";

            // Закрываем соединение
            connection.Close();
        }

        private void BusesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage parent = (MainPage)this.MdiParent;
            parent.busesPage = null;
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            AddBus addBusForm = new AddBus();
            addBusForm.ShowDialog();
            LoadAllBuses();
        }

        private void writeOffBusButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            connection.Open();

            int busId = (int) busesTable.CurrentRow.Cells[0].Value; // Получаем ID автобуса

            string writeOffQuery = "UPDATE BUS SET bus_is_written_off = 1 WHERE bus_id = @busId";

            SqlCommand command = new SqlCommand(writeOffQuery, connection);

            command.Parameters.AddWithValue("@busId", busId);

            command.ExecuteNonQuery();

            connection.Close();

            LoadAllBuses();
        }

        private void busesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.writeOffBusButton.Enabled = true;
            this.updateBusButton.Enabled = true;
            this.addRepairButton.Enabled = true;
            this.showBusRepairsButton.Enabled = true;
        }

        private void updateBusButton_Click(object sender, EventArgs e)
        {
            int busId = (int)busesTable.CurrentRow.Cells[0].Value;

            UpdateBus updateBusForm = new UpdateBus(busId);

            updateBusForm.ShowDialog();

            LoadAllBuses();
        }

        private void addRepairButton_Click(object sender, EventArgs e)
        {
            int busId = (int)busesTable.CurrentRow.Cells[0].Value;

            AddRepairInfo addRepairForm = new AddRepairInfo(busId);

            addRepairForm.ShowDialog();
        }
    }
}
