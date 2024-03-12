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
   
    public partial class Окно_Регистрации : Window
    {
        public Окно_Регистрации()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Окно_Авторизации окно_Авторизации = new Окно_Авторизации();
            окно_Авторизации.Show();
            Close();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = RegLoginBox.Text;
                string password = RegPasswordBox.Password;
                string phone = RegPhoneBox.Text;

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!");
                    return;
                }

                Пользователь NewUser = new Пользователь
                {
                    Логин = login,
                    Пароль = password,
                    Номер_Телефона = phone,
                    Код_Типа_Пользователя = 1
                };
                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Пользователь.Add(NewUser);
                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы зарегистрированы!");
                Окно_Авторизации окно_Авторизации = new Окно_Авторизации();
                окно_Авторизации.Show();
                Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Сбой при проверке данных: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}

