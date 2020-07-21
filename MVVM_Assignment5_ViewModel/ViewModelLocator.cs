using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Assignment5_ViewModel
{
    public class ViewModelLocator
    {
        private static ViewModel _bankVm = new ViewModel();

        public ViewModel MainPage
        {
            get { return _bankVm; }
        }
    }
}
