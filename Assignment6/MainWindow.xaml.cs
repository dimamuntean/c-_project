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
using System.Windows.Threading;
using Microsoft.Win32;


namespace Assignment6
{
    public partial class MainWindow : Window
    {
        private OpenFileDialog aDialog;
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            aDialog = new OpenFileDialog();
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Tick += new EventHandler(dt_Tick);
        }
        void dt_Tick(object sender, EventArgs e)
        {
            progress.Value = MediaElement1.Position.Seconds;
            progress.UpdateLayout();
        }

        void mediaOpened(object sender, EventArgs e)
        {
            progress.Minimum = 0;
            progress.Maximum = MediaElement1.NaturalDuration.TimeSpan.TotalSeconds;
            dt.Start();
        }

        //Open new file
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aDialog.ShowDialog();
            MediaElement1.Source = new Uri(aDialog.FileName);
            title.Content = aDialog.FileName.Split('\\').Last();
            MediaElement1.MediaOpened += new RoutedEventHandler(mediaOpened);
            MediaElement1.Play();
        }

        //Play button

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dt.Start();
            MediaElement1.Play();
        }

        //Pause button
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dt.Stop();
            MediaElement1.Pause();
        }

        //Stop button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dt.Stop();
            progress.Value = 0;
            MediaElement1.Stop();
        }

        private void MediaElement1_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Media loading unsuccessful. " + e.ErrorException.Message);
        }
    }
}
