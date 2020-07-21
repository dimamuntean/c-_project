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

namespace LAB_2_WPF
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

        private void TextBox1_TextChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Event raised by Textbox");
            e.Handled = (bool)radioButton1.IsChecked;
        }

        private void Grid_TextChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Event raised by Grid");
            e.Handled = (bool)radioButton2.IsChecked;
        }

        private void Window_TextChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Event raised by Window");
            e.Handled = (bool)radioButton3.IsChecked;
        }

    }
}
