using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
  
    public partial class Окно_Добавления_Редактирования : Window
    {
        private Товар _currentCloth = new Товар();
        public Окно_Добавления_Редактирования()
        {
            InitializeComponent();
            DataContext = _currentCloth;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

            if (_currentCloth.Код_Товара == 0)
                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().Товар.Add(_currentCloth);
            try
            {
                БОРИСОВ_ТЕКСТИЛЬEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Окно_Менеджера окно_Менеджера = new Окно_Менеджера();
                окно_Менеджера.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG-file(*.png)|*.png|JPEG-file(*.jpg)|*jpg";
            if (openFileDialog.ShowDialog() == true)
                filePath = openFileDialog.FileName;
            else
                return;

            try
            {
                _currentCloth.Фото = File.ReadAllBytes(filePath);
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла");
            }
            AddPhotoButton.Content = "Измениить фото";
        }
    }
}

