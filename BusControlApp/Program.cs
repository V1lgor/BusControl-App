using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusControlApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Служебные настройки WindowsForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем объект формы авторизации
            LoginForm loginForm = new LoginForm();
            
            // Запускаем форму авторизации
            Application.Run(loginForm);

            // Этот кусок кода выполнится исключительно после авторизации

            // Если пользователь таки авторизовался
            if (loginForm.isLoggedIn)
            {
                // Запускаем главную страницу приложения, передав в неё роль пользователя
                Application.Run(new MainPage(loginForm.userRole));
            }
        }
    }
}
