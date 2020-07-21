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
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        ObservableCollection<Multimedia> viewModel;
        public AddItemWindow()
        {
            InitializeComponent();

            //Bind enum to combo box (CD and DVD)
            type.ItemsSource = Enum.GetValues(typeof(Multimedia.MediaType)).Cast<Multimedia.MediaType>();

            //Initialize view model
            viewModel = DataCollection.getCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Add(
                new Multimedia()
                {
                    _artist = artist.Text,
                    _genre = genre.Text,
                    _title = title.Text,
                    _type = type.Text.Equals("DVD") ? Multimedia.MediaType.DVD : Multimedia.MediaType.CD
                });
            Close();
        }
    }
}
