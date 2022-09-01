using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ProjectOshKUU.ViewModels
{
    public static class StaticTimerClose
    {
        public static DispatcherTimer timer = new();
        public static int count { get; set; }
        public static void StaticMethodTimerClose()
        {

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (x, y) =>
            {
                if (count < 10)
                    count++;
            };
            timer.Start();

        }


    }
}
