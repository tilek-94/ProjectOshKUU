using ATB.Infrastructure.Commands;
using Microsoft.EntityFrameworkCore;
using OshKUU.Models;
using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.Data;
using ProjectOshKUU.Data.Services;
using ProjectOshKUU.Data.Services.AbstractServices;
using ProjectOshKUU.View.WindowsPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectOshKUU.ViewModels.Korpus1VM
{
    public class Korpus1Floor1VM : BaseView
    {
        private readonly IAudienceService _service;
        public ICommand? ButtonSelectRoomCommand { get; set; }
        public ICommand? ButtonShowMapCommand { get; set; }
        public ICommand? ButtonInfoCommand { get; set; }
        private bool CanCloseApplicationExecat(object arg) => true;
        public Korpus1Floor1VM(IAudienceService service)
        {
            _service = service;
            GetAllProduct();
            ButtonSelectRoomCommand = new RelayCommand(SelectRoomMethod, CanCloseApplicationExecat);
            ButtonShowMapCommand = new RelayCommand(ShowMapMethod, CanCloseApplicationExecat);
            ButtonInfoCommand = new RelayCommand(CommandMethod, CanCloseApplicationExecat);
            StaticLanguageClass.LanguageDelegate -= DelegatMethod;
            StaticLanguageClass.LanguageDelegate += DelegatMethod;
            DelegatMethod();
        }
        private void SelectRoomMethod(object obj)
        {
            StaticLanguageClass.SelectRoomMethod(obj.ToString());

        }
        private void CommandMethod(object NumberFlat)
        {
            if (StaticLanguageClass.AccessAccount == true)
            {
                AddInformationWindow addInformationWindow = new(1, 1, Convert.ToInt16(NumberFlat), new AudienceService(new AppDbContext()));
                addInformationWindow.Show();
            }
            else
            {
                var e = AudienceNameList.Where(x => x.Number == Convert.ToInt16(NumberFlat)).FirstOrDefault();

                if (e != null)
                {
                    InformationFlat informationFlat = new(e.Name.ToString(), e.InfoAudit.ToString());
                    informationFlat.ShowDialog();
                }
            }


        }
        private void ShowMapMethod(object obj)
        {
            WebBrowsers webBrowsers = new WebBrowsers("https://goo.gl/maps/ERkXv2ZwYFvvGR7U8");
            webBrowsers.ShowDialog();

        }
        private void DelegatMethod()
        {
            if (StaticLanguageClass.Lang == "RU")
            {
                NameToilet = "Туалет";
                LabrName = "Библиотека";
                Restorant = "Сталовая";
                SingleWindow = "Эдиное окно";
                Location = "Где Я?";
            }
            else
            {
                NameToilet = "Ажат кана";
                LabrName = "Китеп кана";
                Restorant = "Аш кана";
                SingleWindow = "Бирдиктүү терезе";
                Location = "Жайгашкан жери";
            }

        }
        private IEnumerable<Audience> _AudienceNameList;
        public IEnumerable<Audience> AudienceNameList
        {
            get { return _AudienceNameList; }
            set { Set(ref _AudienceNameList, value); }
        }

        private async void GetAllProduct()
        {
            await Task.Run(async () =>
            {
                AudienceNameList = await _service.GetByLangAsync(1, StaticLanguageClass.Lang);
                Number1 = AudienceNameList.Where(x => x.Number == 1).Select(t => t.NumberAudit).FirstOrDefault();
                Number2 = AudienceNameList.Where(x => x.Number == 2).Select(t => t.NumberAudit).FirstOrDefault();
                Number3 = AudienceNameList.Where(x => x.Number == 3).Select(t => t.NumberAudit).FirstOrDefault();
                Number4 = AudienceNameList.Where(x => x.Number == 4).Select(t => t.NumberAudit).FirstOrDefault();
                Number5 = AudienceNameList.Where(x => x.Number == 5).Select(t => t.NumberAudit).FirstOrDefault();
                Number6 = AudienceNameList.Where(x => x.Number == 6).Select(t => t.NumberAudit).FirstOrDefault();
                Number7 = AudienceNameList.Where(x => x.Number == 7).Select(t => t.NumberAudit).FirstOrDefault();
                Number8 = AudienceNameList.Where(x => x.Number == 8).Select(t => t.NumberAudit).FirstOrDefault();
                Number9 = AudienceNameList.Where(x => x.Number == 9).Select(t => t.NumberAudit).FirstOrDefault();
                Number10 = AudienceNameList.Where(x => x.Number == 10).Select(t => t.NumberAudit).FirstOrDefault();
                Number11 = AudienceNameList.Where(x => x.Number == 11).Select(t => t.NumberAudit).FirstOrDefault();
                Number12 = AudienceNameList.Where(x => x.Number == 12).Select(t => t.NumberAudit).FirstOrDefault();
                Number13 = AudienceNameList.Where(x => x.Number == 13).Select(t => t.NumberAudit).FirstOrDefault();
                Number14 = AudienceNameList.Where(x => x.Number == 14).Select(t => t.NumberAudit).FirstOrDefault();
                Number15 = AudienceNameList.Where(x => x.Number == 15).Select(t => t.NumberAudit).FirstOrDefault();
                Number16 = AudienceNameList.Where(x => x.Number == 16).Select(t => t.NumberAudit).FirstOrDefault();
                Number17 = AudienceNameList.Where(x => x.Number == 17).Select(t => t.NumberAudit).FirstOrDefault();
                Number18 = AudienceNameList.Where(x => x.Number == 18).Select(t => t.NumberAudit).FirstOrDefault();
                Number19 = AudienceNameList.Where(x => x.Number == 19).Select(t => t.NumberAudit).FirstOrDefault();
                Number20 = AudienceNameList.Where(x => x.Number == 20).Select(t => t.NumberAudit).FirstOrDefault();
                Number21 = AudienceNameList.Where(x => x.Number == 21).Select(t => t.NumberAudit).FirstOrDefault();
                Number22 = AudienceNameList.Where(x => x.Number == 22).Select(t => t.NumberAudit).FirstOrDefault();
                Number23 = AudienceNameList.Where(x => x.Number == 23).Select(t => t.NumberAudit).FirstOrDefault();
                Number24 = AudienceNameList.Where(x => x.Number == 24).Select(t => t.NumberAudit).FirstOrDefault();
                Number25 = AudienceNameList.Where(x => x.Number == 25).Select(t => t.NumberAudit).FirstOrDefault();
                Number26 = AudienceNameList.Where(x => x.Number == 26).Select(t => t.NumberAudit).FirstOrDefault();
                Number27 = AudienceNameList.Where(x => x.Number == 27).Select(t => t.NumberAudit).FirstOrDefault();
            });
        }
    }
}
