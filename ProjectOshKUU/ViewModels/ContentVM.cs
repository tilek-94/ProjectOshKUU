using ATB.Infrastructure.Commands;
using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.Data;
using ProjectOshKUU.Data.Services;
using ProjectOshKUU.View.WindowsPanel;
using ProjectOshKUU.ViewModels.Korpus1VM;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectOshKUU.ViewModels
{
    public class ContentVM : BaseView
    {
        public ICommand? ButtonInfoCommand { get; set; }
        public ICommand? ButtonLangCommand { get; set; }
        public ICommand? ButtonCallWindowCommand { get; set; }
        private bool CanCloseApplicationExecat(object arg) => true;
        public ContentVM()
        {
            CurrentPage = new Korpus1Floor1VM(new AudienceService(new AppDbContext()));
            ButtonInfoCommand = new RelayCommand(CommandMethod, CanCloseApplicationExecat);
            ButtonLangCommand = new RelayCommand(ContentMethod, CanCloseApplicationExecat);
            ButtonCallWindowCommand = new RelayCommand(CallWindowMethod, CanCloseApplicationExecat);
            StaticLanguageClass.SelectRoomDelegate -= x => selectRoomMethod(x); 
            StaticLanguageClass.SelectRoomDelegate += x => selectRoomMethod(x);


        }
        private void CallWindowMethod(object obj)
        {
            OsPanel osPanel = new OsPanel();
            osPanel.ShowDialog();
            
        }
        private void selectRoomMethod(string room)
        {
            switch (room)
            {
                case "toilet":
                    CurrentPage = new Korpus1Floor0VM(new AudienceService(new AppDbContext()));
                    break;
                case "library":
                    CurrentPage = new Korpus1Floor1VM(new AudienceService(new AppDbContext()));
                    break;
                case "Restaurant":
                    CurrentPage = new Korpus1Floor2VM(new AudienceService(new AppDbContext()));
                    break;
                case "SingleWindow":
                    CurrentPage = new Korpus1Floor3VM(new AudienceService(new AppDbContext()));
                    break;
                case "Map":
                    CurrentPage = new Korpus1Floor4VM(new AudienceService(new AppDbContext()));
                    break;
                default:
                    break;
            }
        }
        private void ContentMethod(object obj)
        {
            if (StaticLanguageClass.Lang == "RU")
            {
                NameFaculty = "Кыргызско-Узбекский Международный университет";
            }
            else
            {
                NameFaculty = "Кыргыз-Өзбек эл аралык университтети";
            }
            SeectFloorMethod();
        }
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
        private int floor = 1;
        private async void CommandMethod(object NumberFlat)
        {
            await Task.Run(async () =>
            {
                floor = Convert.ToInt16(NumberFlat);
                SeectFloorMethod();
            });

        }
        private void SeectFloorMethod()
        {
            switch (floor)
            {
                case 0:
                    CurrentPage = new Korpus1Floor0VM(new AudienceService(new AppDbContext()));
                    break;
                case 1:
                    CurrentPage = new Korpus1Floor1VM(new AudienceService(new AppDbContext()));
                    break;
                case 2:
                    CurrentPage = new Korpus1Floor2VM(new AudienceService(new AppDbContext()));
                    break;
                case 3:
                    CurrentPage = new Korpus1Floor3VM(new AudienceService(new AppDbContext()));
                    break;
                case 4:
                    CurrentPage = new Korpus1Floor4VM(new AudienceService(new AppDbContext()));
                    break;
                default:
                    break;
            }
        }

    }
}
