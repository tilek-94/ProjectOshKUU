using ATB.Infrastructure.Commands;
using Microsoft.EntityFrameworkCore;
using OshKUU.Models;
using OshKUU.ViewModels.BaseViewModels;
using ProjectOshKUU.Data;
using ProjectOshKUU.Data.Services;
using ProjectOshKUU.Data.Services.AbstractServices;
using ProjectOshKUU.View.WindowsPanel;
using ProjectOshKUU.ViewModels.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectOshKUU.ViewModels.Korpus3VM
{
    public class Korpus3Floor0VM : AbstractClassBase
    {
        public Korpus3Floor0VM(IAudienceService service, int biulding, int floor) : base(service, biulding, floor)
        {
        }
    }
}
