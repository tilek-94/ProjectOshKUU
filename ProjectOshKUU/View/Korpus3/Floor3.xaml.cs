using OshKUU.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectOshKUU.View.Korpus3
{
    /// <summary>
    /// Логика взаимодействия для Floor2.xaml
    /// </summary>
    public partial class Floor3Kor3 : UserControl
    {
        Button btn;
        public int Id { get; set; }
        public Floor3Kor3()
        {
            btn = new();

            InitializeComponent();
        }

        public void MethodEvendHandler(int x)
        {
            StyleButton();
            switch (x)
            {
                case 1:
                    btn = btn1;
                    break;
                case 2:
                    btn = btn2;
                    break;
                case 3:
                    btn = btn3;
                    break;
                case 4:
                    btn = btn4;
                    break;
                case 5:
                    btn = btn5;
                    break;
                case 6:
                    btn = btn6;
                    break;
                case 7:
                    btn = btn7;
                    break;
                case 8:
                    btn = btn8;
                    break;
                case 9:
                    btn = btn9;
                    break;
                case 10:
                    btn = btn10;
                    break;
                case 11:
                    btn = btn11;
                    break;
                case 12:
                    btn = btn22;
                    break;
                case 13:
                    btn = btn13;
                    break;
                case 14:
                    btn = btn14;
                    break;
                case 15:
                    btn = btn15;
                    break;
                case 16:
                    btn = btn16;
                    break;
                case 17:
                    btn = btn17;
                    break;
                case 18:
                    btn = btn18;
                    break;
                case 19:
                    btn = btn19;
                    break;
                case 20:
                    btn = btn20;
                    break;
                case 21:
                    btn = btn21;
                    break;
                case 22:
                    btn = btn22;
                    break;
                case 23:
                    btn = btn23;
                    break;
                case 24:
                    btn = btn24;
                    break;
                case 25:
                    btn = btn25;
                    break;
                case 26:
                    btn = btn26;
                    break;
                case 27:
                    btn = btn27;
                    break;
            }
        }
        public void StyleButton()
        {
            btn1.Style = (Style)btn1.FindResource("ButtonGrayFLat");
            btn2.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn3.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn4.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn5.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn6.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn7.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn8.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn9.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn10.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn11.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn12.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn13.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn14.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn15.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn16.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn17.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn18.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn19.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn20.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn21.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn22.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn23.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn24.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn25.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn26.Style = (Style)btn2.FindResource("ButtonGrayFLat");
            btn27.Style = (Style)btn2.FindResource("ButtonGrayFLat");

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            MethodEvendHandler(Convert.ToInt16(button.Tag));
            StaticTimerClass.btn = btn;
        }
    }
}