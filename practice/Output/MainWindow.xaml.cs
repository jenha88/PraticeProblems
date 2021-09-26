using System;
using System.Collections.Generic;
using System.IO;
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

namespace Output
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TV_Show> Shows = new List<TV_Show>();

        public MainWindow()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("TV Show Data.txt").Skip(1);

            foreach (var item in lines)
            {
                Shows.Add(new TV_Show(item));
            }
            PopulateListBox(Shows);

        }
        //populting the listbox 
        public void PopulateListBox(List<TV_Show> ss)
        {
            //for each item in our list we add it in the list box 
            lstBox.Items.Clear();
            foreach (var item in ss )
            {
                lstBox.Items.Add(ss);
            }
        }
        public void PopulateRatingFilter()
        {
            RBox.Items.Add("all"); // adding the option into the rating filter 

            foreach (var item in Shows)
            {
                //if they have a blank then show it in the rating combo 
                if (string.IsNullOrEmpty(item.Rated))
                {
                    continue;
                }
                string 
                if (true)
                {

                }
            }
        }
        private void lstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            RBox.SelectedIndex = 0;
            Cbox.SelectedItem = 0;
            LBox.SelectedItem = 0;

        }
    }
}
