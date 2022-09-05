using OshKUU.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectOshKUU.ViewModels.BaseViewModels
{
    public class AbstractContent : BaseView
    {
        public ICommand? ButtonInfoCommand { get; set; }
        public ICommand? ButtonLangCommand { get; set; }
        public ICommand? ButtonCallWindowCommand { get; set; }
        public bool CanCloseApplicationExecat(object arg) => true;
        private BaseView _currentPage;
        public BaseView CurrentPage
        {
            get { return _currentPage; }
            set { Set(ref _currentPage, value); }
        }
        private string _NameFaculty;
        public string NameFaculty
        {
            get { return _NameFaculty; }
            set { Set(ref _NameFaculty, value); }
        }
        public int floor = 1;

    }
}
