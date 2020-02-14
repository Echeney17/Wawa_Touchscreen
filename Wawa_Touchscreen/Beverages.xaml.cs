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

namespace Wawa_Touchscreen
{
    /// <summary>
    /// Interaction logic for Beverages.xaml
    /// </summary>
    public partial class Beverages : Window
    {
        public Beverages()
        {
            InitializeComponent();
        }

        private void btnFruitSmoothies_Click(object sender, RoutedEventArgs e)
        {
            Beverages firstBeverage = new Beverages();
            firstBeverage.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChaiTeas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
