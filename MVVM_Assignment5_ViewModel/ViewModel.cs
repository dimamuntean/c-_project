using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Assignment5_Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace MVVM_Assignment5_ViewModel
{
    public class ViewModel : ViewModelBase
    {
        List<Multimedia> _model;
        public ViewModel()
        {
            _model = new List<Multimedia>();
            _model.Add(new Multimedia()
            {
                _artist = "artist",
                _genre = "genre",
                _title = "title",
                _type = MediaType.CD
            });
        }

        public List<String> MultimediaElements
        {
            get
            {
                return _model.Select(el => el._title).ToList<String>();
            }
        }

        private RelayCommand m_AddItem;
        public RelayCommand AddItem
        {
            get
            {
                if (m_AddItem == null)
                {
                    m_AddItem = new RelayCommand(
                       () =>
                       {
                           _model.Add(new Multimedia() {
                               _artist = "artist",
                               _genre = "genre",
                               _title = "title",
                               _type = MediaType.CD});

                       },
                       () =>
                       {
                           return true;
                       });
                }

                return m_AddItem;
            }
        }

    }
}
