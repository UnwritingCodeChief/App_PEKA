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
    /// Interaction logic for ChatRoom.xaml
    /// </summary>
    public partial class ChatRoom : Window
    {
        public ChatRoom()
        {
            InitializeComponent();
        }

        private void nahujFromChatButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void sendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            //Здесь должен быть вызов метода отправки сообщения
            //Надо будет забиндить inputMessageTextBox, чтобы передавать содержимое сообщения методу
        }

        private void sendMessageCAPSButton_Click(object sender, RoutedEventArgs e)
        {
            //Здесь должен быть вызов метода отправки сообщения КАПСОМ
            //Надо будет забиндить inputMessageTextBox, чтобы передавать содержимое сообщения методу
        }
    }
}
