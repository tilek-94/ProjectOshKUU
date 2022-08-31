using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace OshKUU.ViewModels
{
    public class StaticTimerClass
    {
        public static Button btn;
        public static string LanguageKG="KG";
        public static int TimerMethod()
        {
            DispatcherTimer timer = new();
            btn = new Button();
            int t = 0,count=0;
            timer.Interval = TimeSpan.FromSeconds(0.3);
            timer.Tick += (x, y) =>
            {
                count++;
                if (t == 0)
                {
                    btn.Style = (Style)btn.FindResource("ButtonGrayFLatRed");
                    t = 1;
                }
                else
                {
                    btn.Style = (Style)btn.FindResource("ButtonGrayFLat");
                    t = 0;
                }

            };

            timer.Start();
            return count;
        }
    }
}
