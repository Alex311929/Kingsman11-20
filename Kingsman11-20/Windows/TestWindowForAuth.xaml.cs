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
    /// Логика взаимодействия для TestWindowForAuth.xaml
    /// </summary>
    public partial class TestWindowForAuth : Window
    {
        public TestWindowForAuth()
        {
            InitializeComponent();
        }

        private void BtExit_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }

        private void BtService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
