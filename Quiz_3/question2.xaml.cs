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

namespace Quiz_3
{
    /// <summary>
    /// Interaction logic for question2.xaml
    /// </summary>
    public partial class question2 : Window
    {
        question1 q1 = new question1();
        public question2()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dataGrid.ItemsSource = q1.
        }
    }
}
