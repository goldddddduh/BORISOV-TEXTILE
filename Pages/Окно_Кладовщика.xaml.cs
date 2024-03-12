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
   
    public partial class Окно_Кладовщика : Window
    {
        public Окно_Кладовщика()
        {
            InitializeComponent();
            WareHouseDataGrid.ItemsSource = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Склад.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var ClothForRemoving = WareHouseDataGrid.SelectedItems.Cast<Склад>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ClothForRemoving.Count()} товары?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Склад.RemoveRange(ClothForRemoving);
                    БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    WareHouseDataGrid.ItemsSource = БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Склад.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            return;
        }
    

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Окно_Добавления_Редактирования_Склада окно_Добавления_Редактирования_Склада = new Окно_Добавления_Редактирования_Склада();
            окно_Добавления_Редактирования_Склада.Show();
            Close();
        }
    }
}
