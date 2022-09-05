using OshKUU.ViewModels.BaseViewModels;
using System;
using System.Windows.Threading;

namespace ProjectOshKUU.ViewModels
{
    public class MainWindowVM : BaseView
    {

        private readonly DispatcherTimer timer = new();
        public MainWindowVM()
        {
            CurrentPage = new MainContentVM();
            StaticLanguageClass.SelectBuilding -= (x) => SelectBuildingMethod(x);
            StaticLanguageClass.SelectBuilding += (x) => SelectBuildingMethod(x);
            TimerClose();
        }
        private BaseView? _currentPage;
        public BaseView? CurrentPage
        {
            get { return _currentPage; }
            set { Set(ref _currentPage, value); }
        }
        public void TimerClose()
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
                    CurrentPage = new ContentVM();
                    break;
                case "2":
                    CurrentPage = new ContentVM2();
                    break;
                case "3":
                    CurrentPage = new ContentVM3();
                    break;
                case "4":
                    CurrentPage = new ContentVM4();
                    break;
                case "5":
                    CurrentPage = new ContentVM5();
                    break;
                case "6":
                    CurrentPage = new ContentVM6();
                    break;
                case "site":
                    CurrentPage = new SaitUniversitetVM();
                    break;
                case "avn":
                    CurrentPage = new AvnBrowserVM();
                    break;
                case "main":
                    CurrentPage = new MainContentVM();
                    break;
                default:
                    break;

            }

        }


    }
}
