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
    /// Логика взаимодействия для ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window
    {
        public ServiceWindow()
        {
            InitializeComponent();
            GetListService();


        }
        private void GetListService()
        {
            LvService.ItemsSource = EF.Context.Service.ToList();
        }

        private void LvService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                return;
            }
            var service = button.DataContext as DataBase.Service;

            EditServiceWindow editServiceWindow = new EditServiceWindow();
            editServiceWindow.ShowDialog();

            GetListService();
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();

            GetListService();
        }

        private void BtnCart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
