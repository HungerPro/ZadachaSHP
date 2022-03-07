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

namespace WPFproj
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void redCl(object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.Red;
        }

        private void orangeCl(object sender, RoutedEventArgs e)
        {
            orange.Background = Brushes.Orange;
        }
        private void yellowCl(object sender, RoutedEventArgs e)
        {
            yellow.Background = Brushes.Yellow;
        }
        private void greenCl(object sender, RoutedEventArgs e)
        {
            green.Background = Brushes.LimeGreen;
        }
        private void ligblueCl(object sender, RoutedEventArgs e)
        {
            ligblue.Background = Brushes.Cyan;
        }
        private void blueCl(object sender, RoutedEventArgs e)
        {
            blue.Background = Brushes.Blue;
        }
        private void purpleCl(object sender, RoutedEventArgs e)
        {
            purple.Background = Brushes.DarkViolet;
        }
    }
}
