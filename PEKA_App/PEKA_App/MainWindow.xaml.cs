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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PEKA_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void Nahuj_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Enter_button_Click(object sender, RoutedEventArgs e)
        {
            //Тут должен вызываться метод подключения к дефолтному хосту в трае/кетче с ловлей ошибки
            //Словили ошибку - открываем окно с ошибкой, предлагаем два стула            
            ErrorConnectWindow errorWindow = new ErrorConnectWindow();
            errorWindow.Left = this.Left + 180;
            errorWindow.Top = this.Top + 200;

            //Пока делаем вид что ошибка по дефолту лол
            errorWindow.ShowDialog();
        }
    }
}
