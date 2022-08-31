using ATB.Infrastructure.Commands;
using Microsoft.EntityFrameworkCore;
using OshKUU.Models;
using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.Data;
using ProjectOshKUU.Data.Services.AbstractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectOshKUU.ViewModels.Korpus1VM
{
    public class Korpus1Floor0VM : BaseView
    {
        private readonly IAudienceService _service;
        public ICommand? ButtonSelectRoomCommand { get; set; }
        private bool CanCloseApplicationExecat(object arg) => true;
        public Korpus1Floor0VM(IAudienceService service)
        {
            _service = service;
            GetAllProduct();
            ButtonSelectRoomCommand = new RelayCommand(SelectRoomMethod, CanCloseApplicationExecat);
            StaticLanguageClass.LanguageDelegate -= DelegatMethod;
            StaticLanguageClass.LanguageDelegate += DelegatMethod;
            DelegatMethod();
        }
        private void SelectRoomMethod(object obj)
        {
            StaticLanguageClass.SelectRoomMethod(obj.ToString());
            
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

            });
        }
    }
}

