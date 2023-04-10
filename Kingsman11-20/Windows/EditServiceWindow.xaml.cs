using Kingsman11_20.Res;
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
    /// Логика взаимодействия для EditServiceWindow.xaml
    /// </summary>
    public partial class EditServiceWindow : Window
    {
        DataBase.Service editService = null;
        private bool isEdit = false;
        public EditServiceWindow()
        {
            InitializeComponent();
            isEdit = false;
        }
        public EditServiceWindow(DataBase.Service service)
        {
            InitializeComponent();
            isEdit = true;
            editService = service;

            CmbTypeService.ItemsSource = EF.Context.TypeService.ToList();
            CmbTypeService.DisplayMemberPath = "TypeName";

            ImgImageService.Source = new BitmapImage(new Uri(service.Image));

            TbNameService.Text = service.Title;
            TbDiscService.Text = service.Discription;
            TbPriceService.Text = Convert.ToString(service.Cost);


            CmbTypeService.SelectedItem = EF.Context.TypeService.Where(i => i.Id == service.IdTypeService).FirstOrDefault();

        }
        private void BtnEditService_Click (object sender, RoutedEventArgs e)
        {
            editService.Title = TbNameService.Text;
            editService.Discription = TbDiscService.Text;
            editService.Cost = Convert.ToDecimal(TbPriceService.Text);
            editService.IdTypeService = (CmbTypeService.SelectedItem as DataBase.TypeService).Id;
            EF.Context.SaveChanges();
            MessageBox.Show("Данные усешно сохранены");

            this.Close();
        }
    }
}
