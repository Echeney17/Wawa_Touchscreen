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
    /// Interaction logic for Sandwiches.xaml
    /// </summary>
    public partial class Sandwiches : Window
    {
        public Sandwiches()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }

        private void Sourdough_Sandwich_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }

        private void Flatbread_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }

        private void Roasted_Chicken_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }

        private void Quesedilla_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }

        private void Burrito_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main1 = new MainWindow();
            main1.Show();
        }
    }
}
