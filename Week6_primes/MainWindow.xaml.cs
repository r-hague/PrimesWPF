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

namespace Week6_primes
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

        public void btn_checkPrime_click(object sender, RoutedEventArgs e)
        {
            bool primeBool;
            int x;
            if (int.TryParse(textbox_toCheck.Text, out x))
            {
                primeBool = TestPrime.IsPrime(x);

                if (x > 100)
                {
                    lbl_primeResult.Content = "Please enter an integer under 100.";
                }

               else if (primeBool == true)
                {
                    lbl_primeResult.Content = x + " is a prime number.";
                }

                else
                {
                    lbl_primeResult.Content = x + " is not a prime number.";
                }
            }

            else {
                lbl_primeResult.Content = "Please enter an integer under 100.";
            }
        }

        public void btn_listPrimes_click(object sender, RoutedEventArgs e)
        {
            var primeList = new List<int>();
            primeList = TestPrime.PrimesUpTo(100);
            ListBox.ItemsSource = primeList;
        }


    }
}
