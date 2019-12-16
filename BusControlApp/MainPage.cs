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
        public BusesPage busesPage;  // Форма страницы просмотра автобусов
        public int userRole;         // Роль текущего пользователя

        // Конструктор формы
        public MainPage(int userRole)
        {
            this.userRole = userRole;   // Сохраняем роль пользователя
            InitializeComponent();      // Отрисовываем форму
        }

        // Обработка клика по пункту "Автобусы" главного меню
        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если форма уже открыта, выйти из процедуры
            if (busesPage != null) return;

            // Создаем новую форму страницы автобусов
            busesPage = new BusesPage();

            // Задаем этой форме родительскую, равную текущей форме (текущая форма - родитель новой формы)
            busesPage.MdiParent = this;

            // Меняем размер текущей формы на размер дочерней формы
            this.ClientSize = busesPage.Size;

            // Показываем форму
            busesPage.Show();
        }

        // Событие загрузки формы
        private void MainPage_Load(object sender, EventArgs e)
        {
            // Создаем форму для выбора действия
            SelectActionPage actionPage = new SelectActionPage();

            // Аналогично задаем ей родителя
            actionPage.MdiParent = this;

            // Меняем размер текущей формы на размер дочерней формы
            this.ClientSize = actionPage.Size;

            // Показываем форму
            actionPage.Show();
        }

        // Обработка события активации дочерней формы
        private void MainPage_MdiChildActivate(object sender, EventArgs e)
        {
            Console.WriteLine($"Текущий ребенок: {this.ActiveMdiChild}");

            this.Height += 20;  // Чтобы форма вместилась полностью, необходимо увеличить контейнер на 20 пикселей

        }
    }
}
