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

namespace Wpf_Kuznetsov_A.A._PR2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
        }

        private void B1_Checked(object sender, RoutedEventArgs e)
        {
                if (Dr1.EditingMode == InkCanvasEditingMode.Ink)
                    Dr1.EditingMode = InkCanvasEditingMode.EraseByPoint;
                else
                    Dr1.EditingMode = InkCanvasEditingMode.Ink;
            }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Dr1.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
