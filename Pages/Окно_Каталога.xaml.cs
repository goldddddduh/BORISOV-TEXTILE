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
     
    public partial class Окно_Каталога : Window
    {
        public Окно_Каталога()
        {
            InitializeComponent();
           ProductsDataGrid.ItemsSource = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Товар.ToList();
        }

        private void ProductsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = (Товар)ProductsDataGrid.SelectedItem;
            if (selectedItem != null)
            {
                Окно_Товара окно_Товара = new Окно_Товара(selectedItem);
                окно_Товара.Show();
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.ToLower();
            List<Товар> filteredProducts = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Товар.Where(p => p.Наименование.ToLower().Contains(searchTerm) 
            || p.Техническая_Характеристика.ToLower().Contains(searchTerm)).ToList();
            ProductsDataGrid.ItemsSource = filteredProducts;
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }

}
