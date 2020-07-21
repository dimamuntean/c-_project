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
using System.Diagnostics;


namespace Assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ran dom m_Random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void HeavyWork()
        {
            double secondsToSleep = m_Random.NextDouble() * 10;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }

        public Task HeavyWorkAsync()
        {
            //return Task.Run(async () => await Task.Delay(10000));
            return Task.Run(() => HeavyWork());
        }

        public Task CheckStatus(Task t)
        {
            
            return Task.Run(() => {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (!t.IsCompleted)
                {
                    if(stopwatch.Elapsed.Seconds >= 8)
                    {
                        updateStatus("Work in progress");
                    }
                }
                stopwatch.Stop();
            });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var task1 = HeavyWorkAsync().ContinueWith(t => updateStatus("Task1 completed"));
            var task2 = HeavyWorkAsync().ContinueWith(t => updateStatus("Task2 completed"));
            var task3 = HeavyWorkAsync().ContinueWith(t => updateStatus("Task3 completed"));
            status.Content = "3 Tasks just started";
     
            var task4 = Task.WhenAll(task1, task2,task3);
            var task5 = CheckStatus(task4).ContinueWith(t => updateStatus("All jobs completed"));
        }

        private void updateStatus(String sts)
        {
            this.Dispatcher.Invoke(() =>
            {
                status.Content = sts;
            });
        }
    }
}
