using Kingsman11_20.Res;
using Microsoft.Win32;
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

namespace Kingsman11_20.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private string pathImage = null;
        public AddWindow()
        {
            InitializeComponent();
            CmbTypeService.ItemsSource = EF.Context.Service.ToList();
            CmbTypeService.DisplayMemberPath = "TypeName";
            CmbTypeService.SelectedIndex = 0;
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImgImageService.Source = new BitmapImage(new Uri(openFileDialog.FileName));

                pathImage = openFileDialog.FileName;
            }
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Service newService = new DataBase.Service();

            newService.Title = TbNameService.Text;
            newService.Cost = Convert.ToDecimal(TbPriceService.Text);
            newService.Discription = TbDiscService.Text;
            newService.IdTypeService = (CmbTypeService.SelectedItem as DataBase.TypeService).Id;
            if (pathImage != null)
            {
                newService.Image = pathImage;
            }

            EF.Context.Service.Add(newService);
            EF.Context.SaveChanges();

            MessageBox.Show("Услуга добавлена", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            this.Close();
        }
    }
}
