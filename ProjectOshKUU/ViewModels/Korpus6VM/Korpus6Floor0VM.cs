﻿using ATB.Infrastructure.Commands;
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

namespace ProjectOshKUU.ViewModels.Korpus6VM
{
    public class Korpus6Floor0VM : AbstractClassBase
    {
        public Korpus6Floor0VM(IAudienceService service, int biulding, int floor) : base(service, biulding, floor)
        {
        }
    }
}
