using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Win32;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Kuznetsov_A.A._PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данное приложение разработал студент\n                 402 группы Кузнецов А.А.\n                          города Амурск  ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Перекрашивает фон в серый цвет";
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Показывает информацию о разработчике программы";
        }

        private void Button_MouseLeave_1(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Закрывает программу";
        }

        private void Button_MouseLeave_2(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_3(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Перекрашивает фон в серый цвет";
        }

        private void Button_MouseLeave_3(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_4(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Показывает информацию о разработчике программы";
        }

        private void Button_MouseLeave_4(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_5(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Закрывает программу";
        }

        private void Button_MouseLeave_5(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_MouseEnter_6(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Открывает задание №2";
        }

        private void Button_MouseLeave_6(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }
    }
}
