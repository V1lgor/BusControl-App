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
        // Сохраняем подключение к БД в виде отдельного свойства, чтобы каждый раз не создавать подключение
        private SqlConnection connection;

        public int userRole;

        // Конструктор формы просмотра автобусов
        public BusesPage(int userRole)
        {
            // Создаем подключение к БД
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            this.connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();  // Открываем соединение

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

            InitializeComponent();  // Отрисовываем форму

            // Насильно выравниваем кнопку "Добавить автобус" по таблице автобусов
            this.addBusBtn.Location = new Point(20, this.addBusBtn.Location.Y);

            Console.WriteLine("Создана форма BusesPage!");

            this.userRole = userRole;
        }


        // Событие загрузки формы
        private void BusesPage_Load(object sender, EventArgs e)
        {
            // Заставляем форму растянуться по контейнеру
            this.Dock = DockStyle.Fill;

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
            foreach(DataGridViewColumn column in busesTable.Columns)
            {
                column.ReadOnly = true; // И задаем им свойство ReadOnly
            }
            // Задаем источник данных для таблицы на форме как 0-ю 
            // (в данном случае еще и единственную) таблицу из датасета
            busesTable.DataSource = ds.Tables[0];

            if (userRole == 2) 
            {
                Console.WriteLine("Скрываю столбцы таблицы");
                busesTable.Columns["busId"].Visible = false;
                busesTable.Columns["busVIN"].Visible = false;
                busesTable.Columns["busGarageNumber"].Visible = false;
                busesTable.Columns["busTankVolume"].Visible = false;
            }
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
            // Открываем соединение
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

            // Закрываем соединение
            connection.Close();
        }

        private void BusesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage parent = (MainPage)this.MdiParent;
            parent.busesPage = null;
        }
    }
}
