using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.View.Korpus1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ProjectOshKUU.ViewModels
{
    public class MainWindowVM : BaseView
    {
        ContentWindow contentWindow;
        private DispatcherTimer timer = new();
        public MainWindowVM()
        {
           //CurrentPage =new ContentVM();
            CurrentPage=new MainContentVM();
            StaticLanguageClass.SelectBuilding -= (x) => SelectBuildingMethod(x);
            StaticLanguageClass.SelectBuilding += (x) => SelectBuildingMethod(x);
            TimerClose();
        }

        public void  TimerClose()
        {
            timer.Start();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (x, y) =>
            {
                if (StaticTimerClose.count > 20)
                {
                    CurrentPage = new MainContentVM();
                    timer.Stop();
                }
            };
           

        }
        private void SelectBuildingMethod(string building)
        {
            timer.Start();
            StaticTimerClose.count = 0;
            switch (building)
            {
                case "1":
                        CurrentPage=new ContentVM();

                    break;
                case "2":
                    CurrentPage = new ContentVM2();
                    break;
                case "3":
                    CurrentPage = new ContentVM3();
                    break;
                case "site":
                    CurrentPage = new SaitUniversitetVM();
                    break;
                case "avn":
                    CurrentPage = new AvnBrowserVM();
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
