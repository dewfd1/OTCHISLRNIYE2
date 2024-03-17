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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YADERNYiENTITY2.MPT1DataSetTableAdapters;

namespace YADERNYiENTITY2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Pagel_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page1();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page2();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Content = new Page3();
        }
    }
}
