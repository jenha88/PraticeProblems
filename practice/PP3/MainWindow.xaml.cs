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

namespace PP3
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
            double pp = 0;
            string manufacturer = txtM.Text;
            string image = txtI.Text;
            string price = txtP.Text;
            string name = txtN.Text;

            if (string.IsNullOrEmpty(manufacturer)==true)
            {
                Console.WriteLine("that is an invalid manufacturer");
            }
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("that is an invalid manufacturer");
            }
            if (string.IsNullOrEmpty(image) == true)
            {
                Console.WriteLine("that is an invalid image");
            }
            if (double.TryParse(price,out pp)==false)
            {
                Console.WriteLine("that is an invalid price");

            }

            Toy List = new Toy() //setting a constructor 
            {
                Manufacturer = manufacturer,
                Name = name,
                Image = image,
                Price = pp
            };
            lstbox.Items.Add(List) //addings items to the listbox
        }

   
        private void lstbox_SelectionChanged(object sender, SelectionChangedEventArgs e) //list box functions 
        {
            Toy selectedToy = (Toy)lstbox.SelectedItem; //what is the selecteditem 
            var uri = new Uri(selectedToy.Image);//below are how to set up the images 
            var img = new BitmapImage(uri);
            Imgbox.Source = img; // need clarification 
            MessageBox.Show($"{selectedToy.GetAisle()}"); //what the message would show when you click on the company name 
        }
    }
}
