using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Configuration;

namespace BusControlApp
{
    public partial class LoginForm : Form
    {
        public int userRole;            // Роль пользователя
        public bool isLoggedIn;         // Показывает, авторизовался ли пользователь

        public LoginForm()
        {
            InitializeComponent();      // Служебное
        }

        // Обработчик события клика по кнопке "Войти"
        // Для создания обработчика необходимо зайти в свойства объекта в Конструкторе формы, указать ему свойство Name
        // (данное свойство будет именем, позволяющим ссылаться на этот объект), после чего перейти во вкладку "События"
        // (иконка молнии) и выбрать событие Click. 
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Получаем значения логина и пароля в полях ввода
            // ВСЕ объекты на форме следует именовать так, чтобы к ним было удобно и логично обращаться в коде.
            // Имя объекта есть свойство Name искомого объекта
            string login = this.loginField.Text;
            string password = this.passwordField.Text;

            // Создаем соединение с БД
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            // Открываем соединение с БД
            connection.Open();

            // Создаем объект SQL запроса.
            // Конструктор SQLCommand принимает 2 параметра: строка запроса и объект соединения с БД
            // В запросе указаны значения @login и @password. Это - параметры запроса, устанавливаемые 
            // далее программным путем на основе значений в соответствующих полях
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_login = @login AND user_password = @password", connection);

            // Создаем параметры для запроса.
            // Конструктор объектов SqlParameter принимает 3 значения - имя параметра, его SQL-тип и размер этого типа.
            // 2-й и 3-й параметры нужны для корректной валидации данных.
            SqlParameter loginParam = new SqlParameter("@login", SqlDbType.VarChar, 30);
            SqlParameter passwordParam = new SqlParameter("@password", SqlDbType.VarChar, 255);

            // Свойство Value объектов SqlParameter есть значение параметра, которое мы будем вставлять в запрос.
            loginParam.Value = login;
            passwordParam.Value = password;

            // Добавляем полученные объекты параметров к коллекции Parameters искомого запроса.
            command.Parameters.Add(loginParam);
            command.Parameters.Add(passwordParam);

            // Создаем объект SqlDataReader, позволяющий считывать данные, и присваиваем ему результат выполнения
            // команды ExecuteReader, вызванной у искомого запроса.
            SqlDataReader userReader = command.ExecuteReader();

            // Если в результате выполнения запроса не вернулось ни одной строки
            if (!userReader.HasRows)
            {
                // Показываем сообщение об ошибке
                MessageBox.Show("Логин или пароль введены неправильно!", "Ошибка входа",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прекращаем обработку клика
            }

            // Считываем первую (и единственную в данном случае) строку из userReader
            // В этой строке будут данные искомого пользователя
            userReader.Read();

            // Проверяем значение user_role в этой строке и запоминаем эту роль.
            // Метод SqlDataReader.GetValue(i) возвращает значение i-го столбца строки, 
            // которая находится в данный момент в SqlDataReader
            switch (userReader.GetValue(2))
            {
                case "admin":
                    this.userRole = 1;
                    break;
                case "user":
                    this.userRole = 2;
                    break;
            }

            // Сигнализируем, что авторизация завершена успешно
            this.isLoggedIn = true;

            // И закрываем форму
            this.Close();

        }
    }
}
