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

    public partial class Окно_Добавления_Редактирования_Склада : Window
    {
        private Склад _currentCloth = new Склад();
        public Окно_Добавления_Редактирования_Склада()
        {
            InitializeComponent();
            DataContext = _currentCloth;
            ComboCLoth.ItemsSource = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Товар.ToList();
        }



        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentCloth.Код_Склада == 0)
                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Склад.Add(_currentCloth);
            try
            {
                if (DateTime.TryParse(Дата_Поступления.Text, out DateTime date))
                {
                    _currentCloth.Дата_Поступления = date;
                }
                else
                {
                    MessageBox.Show("Введите корректную дату");
                    return;
                }


                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Окно_Кладовщика окно_кладовщика = new Окно_Кладовщика();
                окно_кладовщика.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
