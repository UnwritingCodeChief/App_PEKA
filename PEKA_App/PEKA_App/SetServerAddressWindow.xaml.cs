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
    /// Interaction logic for SetServerAddressWindow.xaml
    /// </summary>
    public partial class SetServerAddressWindow : Window
    {
        public SetServerAddressWindow()
        {
            InitializeComponent();
        }

        private void addressSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //Woha, kostily-kostiliky
            ChatRoom chatRoom = new ChatRoom();
            chatRoom.Left = this.Left - 180;
            chatRoom.Top = this.Top - 200;
            Application.Current.MainWindow.Hide();
            this.Close();

            //Тут должен вызываться метод для подключения к конкретному адресу
            //Пока просто показывается заготовка окна, тип мы уже подключились лол
            //Надо будет забиндить addressTextBox, чтобы было что передавать методу
            chatRoom.Show();
        }
    }
}
