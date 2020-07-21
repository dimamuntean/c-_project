using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Assignment5
{
    class DataCollection
    {
        private static ObservableCollection<Multimedia> viewModel;
        public static ObservableCollection<Multimedia> getCollection()
        {
            if (viewModel == null)
            {
                viewModel = new ObservableCollection<Multimedia> ();
            }
            return viewModel;
        }
    }
}
