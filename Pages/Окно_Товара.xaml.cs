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
   
    public partial class Окно_Товара : Window
    {
        public Окно_Товара(Товар selectedItem)
        {
            InitializeComponent();
             if (selectedItem != null)
            {
                ProductNameLabel.Content = selectedItem.Наименование;
                ProductDescriptionLabel.Content = selectedItem.Описание;
                ProductPropertyLabel.Content = selectedItem.Техническая_Характеристика;
                ProductPriceLabel.Content = selectedItem.Цена.ToString() + " рублей"; ;
                if (selectedItem.Фото != null && selectedItem.Фото.Length > 0)
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = new MemoryStream(selectedItem.Фото);
                    bitmapImage.EndInit();
                    ProductImage.Source = bitmapImage;
                }
            }
        }
    }
}
