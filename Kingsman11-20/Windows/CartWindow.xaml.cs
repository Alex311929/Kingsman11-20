﻿using System;
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
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            GetListService();
           
        }

        private void GetListService()
        {
            LvService.ItemsSource = ClassHelper.CartServiceClass.ServiceCart;
        }

        private void BtnRomoveToCart_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var service = button.DataContext as DataBase.Service;

            ClassHelper.CartServiceClass.ServiceCart.Remove(service);

            GetListService();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow serviceWindow = new ServiceWindow();
            serviceWindow.Show();
            this.Close();
        }

        private void LvService_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtBuy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
