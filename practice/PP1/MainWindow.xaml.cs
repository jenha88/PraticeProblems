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

namespace PP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            labOut.Visibility = Visibility.Hidden; //when the program beings the label does not appear 
        }


        private void btb_Click(object sender, RoutedEventArgs e)
        {
            string birth = txtB.Text; //setting the birthday 
            DateTime dob = Convert.ToDateTime(birth);//converting the birthday to date 
            string first = txtF.Text;//setting the firstname 
            string last = txtL.Text;//setting the lastname 
            TimeSpan age = DateTime.Now-dob;//subtracting the time now minus your date of birth
            int years = age.Days / 365;

            labOut.Content = $"Hello there {first}! You're {years.ToString("G0")}!";//return 
            labOut.Visibility = Visibility.Visible; // once the user input the answer the output would be visable 

        }
    }
}

