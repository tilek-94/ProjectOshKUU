using ATB.Infrastructure.Commands;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.Data.Services;
using ProjectOshKUU.Data;
using ProjectOshKUU.ViewModels.Korpus1VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OshKUU.Models;
using View.WindowsPanel;

namespace ProjectOshKUU.ViewModels
{
    public class MainContentVM : BaseView
    {
        public ICommand? ButtonOpenMap { get; set; }
        public ICommand? ButtonOpenAVN { get; set; }
        public ICommand? ButtonOpenSite { get; set; }
        private bool CanCloseApplicationExecat(object arg) => true;
        //private StaticTimerClose StaticTimerClose;

        public MainContentVM()
        {
            //StaticTimerClose = new();
            ButtonOpenMap = new RelayCommand(CommandMethod, CanCloseApplicationExecat);
            ButtonOpenSite = new RelayCommand(CommandMethod2, CanCloseApplicationExecat);
            ButtonOpenAVN = new RelayCommand(CommandOpenAvnMethod, CanCloseApplicationExecat);

        }

        private void CommandOpenAvnMethod(object obj)
        {
            StaticLanguageClass.SelectBuildingMethod("avn");
        }

        private string _test;
        public string test
        {
            get { return _test; }
            set { Set(ref _test, value); }
        }

        private void CommandMethod2(object obj)
        {
            /*SaitWindow wn = new();
            wn.ShowDialog();*/
            StaticLanguageClass.SelectBuildingMethod("site");
        }

        private void CommandMethod(object obj)
        {
            StaticLanguageClass.SelectBuildingMethod("1");
        }
    }
}
