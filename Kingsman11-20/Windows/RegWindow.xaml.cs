using Kingsman11_20.Res;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            CmbGender.ItemsSource = EF.Context.Gender.ToList();
            CmbGender.DisplayMemberPath = "GenderName";
            CmbGender.SelectedIndex = 0;
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TbFirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            
            DataBase.Client addClinet = new DataBase.Client();
            addClinet.FName = TbFirstName.Text;
            addClinet.LName = TbLastName.Text;
            addClinet.Phone = TbPhone.Text;
            addClinet.IdGender = (CmbGender.SelectedItem as DataBase.Gender).Id;

            EF.Context.Client.Add(addClinet);
            EF.Context.SaveChanges();
            MessageBox.Show("Клиент добавлен");
        }
        
    }
}
