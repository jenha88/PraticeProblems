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

namespace HW2Part1
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

        private void btb_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(FName.Text) == true)
            {
                MessageBox.Show("That is an invalid first name");
            }
            if (string.IsNullOrEmpty(LName.Text) == true)
            {
                MessageBox.Show("That is an invalid last name");
            }
            if (string.IsNullOrEmpty(MajBox.Text) == true)
            {
                MessageBox.Show("That is an invalid major name");
            }
            double gpa=0;
            if (double.TryParse(GPABox.Text, out gpa) == false)
            {
                MessageBox.Show("that is an invalid gpa");
            }
            int streetnum=0;
            if (int.TryParse(StNum.Text, out streetnum) == false)
            {
                MessageBox.Show("that is an invalid streetnum");
            }
            if (string.IsNullOrEmpty(StrtNam.Text) == true)
            {
                MessageBox.Show("that is an invalid street name");

            }
            if (string.IsNullOrEmpty(StateNam.Text)==true)
            {
                MessageBox.Show("that is an invalid state name ");
            }
            if (string.IsNullOrEmpty(CityName.Text)==true)
            {
                MessageBox.Show("that is an invalid city");
            }
            int zip=0;
            if (int.TryParse(ZipBox.Text,out zip)==false)
            {
                MessageBox.Show("that is an invalid zipcode");
            }
    
        }
    }
}
