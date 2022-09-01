using ProjectOshKUU.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для InformationFlat.xaml
    /// </summary>
    public partial class InformationFlat : Window
    {
        private string _head { get; set; }
        private string _Content { get; set; }
        public InformationFlat(string Head, string Content)
        {
            
            InitializeComponent();
            _Content = Content;
            _head = Head;
            TimerMethod();
        }
        private  void TimerMethod()
        {
            DispatcherTimer timer = new();
            
            int  count = 0;
            timer.Start();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (x, y) =>
            {
                count++;
                if(count > 20)
                {
                    timer.Stop();
                    this.Close();

                }
            };

            
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtHead.Text = _head;
            txtContent.Text = _Content;
            StaticTimerClose.count = 0;
            StaticTimerClose.timer.Stop();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            StaticTimerClose.timer.Start();
        }
    }
}
