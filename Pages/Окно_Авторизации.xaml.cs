using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using БОРИСОВ_ТЕКСТИЛЬ.Model;

namespace БОРИСОВ_ТЕКСТИЛЬ.Pages
{
   
    public partial class Окно_Авторизации : Window
    {
        public Окно_Авторизации()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Password;
            Пользователь user = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Пользователь.Where(u => u.Логин == login).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверный логин!");
            }
           
            if (user.Пароль != password)
            {
                MessageBox.Show("Неверный пароль!");
            }
            else
            {
                int UserType = user.Код_Типа_Пользователя;
                AppData.UserId = user.Код_Пользователя;
                switch (UserType)
                {
                    case 1:
                        MessageBox.Show("Добро пожаловать пользователь!");
                        AppData.UserRole = 1;
                        Окно_Каталога окно_Каталога = new Окно_Каталога();
                        окно_Каталога.Show();
                        Close();
                        break;
                    case 2:
                        MessageBox.Show("Добро пожаловать менеджер!");
                        AppData.UserRole = 2;
                        Окно_Менеджера окно_Менеджера = new Окно_Менеджера();
                        окно_Менеджера.Show();
                        Close();
                        break;
                    case 3:
                        MessageBox.Show("Добро пожаловать кладовщик!");
                        AppData.UserRole = 3;
                        Окно_Кладовщика окно_Кладовщика = new Окно_Кладовщика();
                        окно_Кладовщика.Show();
                        Close();
                        break;
                    default:
                        MessageBox.Show("Что-то пошло не так..");
                        break;
                }
            }
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Окно_Регистрации окно_Регистрации = new Окно_Регистрации();
            окно_Регистрации.Show();
            Close();
        }
    }
}
