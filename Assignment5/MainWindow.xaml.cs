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
using System.Collections.Specialized;
using System.Collections.ObjectModel;


namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Multimedia> viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = DataCollection.getCollection();
            viewModel.CollectionChanged += HandleChange;
        }

        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var x in e.NewItems)
            {
                listBox.Items.Add(x);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                titleText.Text = (listBox.SelectedItem as Multimedia)._title;
                artistText.Text = (listBox.SelectedItem as Multimedia)._artist;
                genreText.Text = (listBox.SelectedItem as Multimedia)._genre;
                switch ((listBox.SelectedItem as Multimedia)._type)
                {
                    case Multimedia.MediaType.DVD:
                        typeText.Text = "DVD"; break;
                    case Multimedia.MediaType.CD:
                        typeText.Text = "CD"; break;
                    default:
                        typeText.Text = ""; break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow modalWindow = new AddItemWindow();
            modalWindow.ShowDialog();
        }
    }
}
