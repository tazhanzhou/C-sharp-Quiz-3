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
    /// Interaction logic for question1.xaml
    /// </summary>
    public partial class question1 : Window
    {
        IList<Student> studentList = new List<Student>();

        public question1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student
                (
                Int32.Parse(tbxId.Text),
                tbxFName.Text,
                tbxLName.Text,
                Checkregisterd.IsChecked ?? false
                );
            studentList.Add(stu);
            int num = studentList.Count();

            MessageBox.Show($"There are {num.ToString()} added students");


        }
    }
}
