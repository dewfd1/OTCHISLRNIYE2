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
using YADERNYi2.MPT1DataSetTableAdapters;

namespace YADERNYi2
{
    public partial class Page3 : Page
    {
        StudentsTableAdapter student = new StudentsTableAdapter();
        public Page3()
        {
            InitializeComponent();
            MPT1.ItemsSource = student.GetData();
        }
    }
}