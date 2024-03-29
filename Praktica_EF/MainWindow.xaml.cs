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

namespace Praktica_EF
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

        private void Str_One_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page1();
        }

        private void Str_two_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page2();
        }

        private void Str_three_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page3();
        }
    }
}
