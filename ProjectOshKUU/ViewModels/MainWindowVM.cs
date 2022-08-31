using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.View.Korpus1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectOshKUU.ViewModels
{
    public class MainWindowVM : BaseView
    {
        ContentWindow contentWindow;

       public MainWindowVM()
        {
            CurrentPage =new ContentVM();
            StaticLanguageClass.SelectBuilding -= (x) => SelectBuildingMethod(x);
            StaticLanguageClass.SelectBuilding += (x) => SelectBuildingMethod(x);
        }
        private void SelectBuildingMethod(string building)
        {
            switch (building)
            {
                case "1":
                        CurrentPage=new ContentVM();
                    break;
                case "2":
                    CurrentPage = new ContentVM2();
                    break;
                default:
                    break;

            }

        }
        private BaseView _currentPage;
        public BaseView CurrentPage
        {
            get { return _currentPage; }
            set { Set(ref _currentPage, value); }
        }

    }
}
