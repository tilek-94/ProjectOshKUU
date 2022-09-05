using ATB.Infrastructure.Commands;
using OshKUU.Models;
using ProjectOshKUU.Data.Services.AbstractServices;
using ProjectOshKUU.Data.Services;
using ProjectOshKUU.Data;
using ProjectOshKUU.View.WindowsPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using OshKUU.ViewModels.BaseViewModels;
using System.Windows;

namespace ProjectOshKUU.ViewModels.BaseViewModels
{
    public  class AbstractClassBase:BaseView
    {
        #region Основной логика
        public readonly IAudienceService _service;
        public ICommand? ButtonSelectRoomCommand { get; set; }
        public ICommand? ButtonShowMapCommand { get; set; }
        public ICommand? ButtonInfoCommand { get; set; }
        public int Floor { get; set; }
        public int Biulding { get; set; }
        private bool CanCloseApplicationExecat(object arg) => true;
        public AbstractClassBase(IAudienceService service, int biulding, int floor)
        {
            Floor = floor;
            Biulding = biulding;
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
            StaticTimerClose.count = 0;

            StaticLanguageClass.SelectRoomMethod(obj.ToString());
            //Number1 = StaticTimerClose.count.ToString();
        }
        private void CommandMethod(object NumberFlat)
        {
            StaticTimerClose.count = 0;
            if (StaticLanguageClass.AccessAccount == true)
            {
                AddInformationWindow addInformationWindow = new(Floor, Biulding, Convert.ToInt16(NumberFlat), new AudienceService(new AppDbContext()));
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
            //WebBrowsers webBrowsers = new WebBrowsers("https://goo.gl/maps/ERkXv2ZwYFvvGR7U8");
            WebBrowsers webBrowsers = new WebBrowsers("https://kuu.kg/");
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

        public async void GetAllProduct()
        {
            await Task.Run(async () =>
            {
                AudienceNameList = await _service.GetByLangAsync(Floor, Biulding, StaticLanguageClass.Lang);

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

        #endregion Основной логика

        #region Properties
        private string? _Number1;
        public string? Number1
        {
            get
            {
                return _Number1;
            }
            set
            {
                Set(ref _Number1, value);
            }
        }
        private string? _Number2;
        public string? Number2
        {
            get
            {
                return _Number2;
            }
            set
            {
                Set(ref _Number2, value);
            }
        }

        private string? _Number3;
        public string? Number3
        {
            get
            {
                return _Number3;
            }
            set
            {
                Set(ref _Number3, value);
            }
        }
        private string? _Number4;
        public string? Number4
        {
            get
            {
                return _Number4;
            }
            set
            {
                Set(ref _Number4, value);
            }
        }

        private string? _Number5;
        public string? Number5
        {
            get
            {
                return _Number5;
            }
            set
            {
                Set(ref _Number5, value);
            }
        }

        private string? _Number6;
        public string? Number6
        {
            get
            {
                return _Number6;
            }
            set
            {
                Set(ref _Number6, value);
            }
        }
        private string? _Number7;
        public string? Number7
        {
            get
            {
                return _Number7;
            }
            set
            {
                Set(ref _Number7, value);
            }
        }
        private string? _Number8;
        public string? Number8
        {
            get
            {
                return _Number8;
            }
            set
            {
                Set(ref _Number8, value);
            }
        }
        private string? _Number9;
        public string? Number9
        {
            get
            {
                return _Number9;
            }
            set
            {
                Set(ref _Number9, value);
            }
        }
        private string? _Number10;
        public string? Number10
        {
            get
            {
                return _Number10;
            }
            set
            {
                Set(ref _Number10, value);
            }
        }
        private string? _Number11;
        public string? Number11
        {
            get
            {
                return _Number11;
            }
            set
            {
                Set(ref _Number11, value);
            }
        }
        private string? _Number12;
        public string? Number12
        {
            get
            {
                return _Number12;
            }
            set
            {
                Set(ref _Number12, value);
            }
        }

        private string? _Number13;
        public string? Number13
        {
            get
            {
                return _Number13;
            }
            set
            {
                Set(ref _Number13, value);
            }
        }
        private string? _Number14;
        public string? Number14
        {
            get
            {
                return _Number14;
            }
            set
            {
                Set(ref _Number14, value);
            }
        }

        private string? _Number15;
        public string? Number15
        {
            get
            {
                return _Number15;
            }
            set
            {
                Set(ref _Number15, value);
            }
        }

        private string? _Number16;
        public string? Number16
        {
            get
            {
                return _Number16;
            }
            set
            {
                Set(ref _Number16, value);
            }
        }
        private string? _Number17;
        public string? Number17
        {
            get
            {
                return _Number17;
            }
            set
            {
                Set(ref _Number17, value);
            }
        }
        private string? _Number18;
        public string? Number18
        {
            get
            {
                return _Number18;
            }
            set
            {
                Set(ref _Number18, value);
            }
        }
        private string? _Number19;
        public string? Number19
        {
            get
            {
                return _Number19;
            }
            set
            {
                Set(ref _Number19, value);
            }
        }
        private string? _Number21;
        public string? Number21
        {
            get
            {
                return _Number21;
            }
            set
            {
                Set(ref _Number21, value);
            }
        }
        private string? _Number22;
        public string? Number22
        {
            get
            {
                return _Number22;
            }
            set
            {
                Set(ref _Number22, value);
            }
        }

        private string? _Number23;
        public string? Number23
        {
            get
            {
                return _Number23;
            }
            set
            {
                Set(ref _Number23, value);
            }
        }
        private string? _Number24;
        public string? Number24
        {
            get
            {
                return _Number24;
            }
            set
            {
                Set(ref _Number24, value);
            }
        }

        private string? _Number25;
        public string? Number25
        {
            get
            {
                return _Number25;
            }
            set
            {
                Set(ref _Number25, value);
            }
        }

        private string? _Number26;
        public string? Number26
        {
            get
            {
                return _Number26;
            }
            set
            {
                Set(ref _Number26, value);
            }
        }
        private string? _Number27;
        public string? Number27
        {
            get
            {
                return _Number27;
            }
            set
            {
                Set(ref _Number27, value);
            }
        }
        private string? _Number28;
        public string? Number28
        {
            get
            {
                return _Number28;
            }
            set
            {
                Set(ref _Number28, value);
            }
        }
        private string? _Number29;
        public string? Number29
        {
            get
            {
                return _Number29;
            }
            set
            {
                Set(ref _Number29, value);
            }
        }
        private string? _Number20;
        public string? Number20
        {
            get
            {
                return _Number20;
            }
            set
            {
                Set(ref _Number20, value);
            }
        }


        #endregion Properties
    }
}
