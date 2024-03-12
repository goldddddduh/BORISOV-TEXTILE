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
using System.Windows.Navigation;
using System.Windows.Shapes;
using БОРИСОВ_ТЕКСТИЛЬ.Pages;

namespace БОРИСОВ_ТЕКСТИЛЬ
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CatalogButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добро пожаловать гость!");
            Окно_Каталога окно_Каталога = new Окно_Каталога();
            окно_Каталога.Show();
            Close();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Окно_Авторизации окно_Авторизации = new Окно_Авторизации();
            окно_Авторизации.Show();
            Close();
        }
    }
}
