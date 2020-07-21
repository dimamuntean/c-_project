using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;
using MVVM_Assignment5_ViewModel;
using MVVM_Assignment5_Model;

namespace MVVM_Assignment5_View
{
    public class Converters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                List<Multimedia> listvalue = (List<Multimedia>)value;
                listvalue.Select(el => el._title);
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
