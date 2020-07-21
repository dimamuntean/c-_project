using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11_WPF_LIBRARY
{
    public class CustomControl1
    {
        public static readonly DependencyProperty TimeProperty;
        System.Timers.Timer myTimer = new System.Timers.Timer();
        delegate void SetterDelegate();
        public static CustomControl1()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            TimeProperty = DependencyProperty.Register("Time", typeof(string), typeof(CustomControl1), metadata);
        }
        public CustomControl1()
        {
            myTimer.Elapsed += timer_elapsed;
            myTimer.Interval = 1000;
            myTimer.Start();
            this.DataContext = this;
        }
    }
}
