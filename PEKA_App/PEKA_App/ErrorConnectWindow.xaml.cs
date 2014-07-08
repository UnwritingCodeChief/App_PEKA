using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PEKA_App
{
    /// <summary>
    /// Interaction logic for ErrorConnectWindow.xaml
    /// </summary>
    public partial class ErrorConnectWindow : Window
    {
        public ErrorConnectWindow()
        {
            InitializeComponent();
        }

        private void enterAddressButton_Click(object sender, RoutedEventArgs e)
        {            
            SetServerAddressWindow addressWindow = new SetServerAddressWindow();
            addressWindow.Left = this.Left;
            addressWindow.Top = this.Top;            
            this.Close();

            addressWindow.ShowDialog();
        }

        private void becomeHostButton_Click(object sender, RoutedEventArgs e)
        {
            ChatRoom chatRoom = new ChatRoom();          
            this.Close();
            Application.Current.MainWindow.Hide();

            //Здесь должен быть вызов метода создания хоста
            //Пока просто показывается заготовка окна, тип мы уже хост лол
            chatRoom.Show();
        }
    }
}
