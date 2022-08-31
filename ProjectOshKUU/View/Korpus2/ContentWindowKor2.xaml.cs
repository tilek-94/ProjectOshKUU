using ProjectOshKUU.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectOshKUU.View.Korpus2
{
    /// <summary>
    /// Логика взаимодействия для ContentWindowKor2.xaml
    /// </summary>
    public partial class ContentWindowKor2 : UserControl
    {
        public ContentWindowKor2()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            StyeleButtonFloor(btn2);
        }
        private void StyeleButtonFloor(Button btn)
        {
            btn1.Style = (Style)btn1.FindResource("ButtonFloor");
            btn2.Style = (Style)btn2.FindResource("ButtonFloor");
            btn3.Style = (Style)btn2.FindResource("ButtonFloor");
            btn4.Style = (Style)btn2.FindResource("ButtonFloor");
            btn0.Style = (Style)btn2.FindResource("ButtonFloor");
            btn.Style = (Style)btn.FindResource("ButtonFloorRed");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.DelegateMethod("RU");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.DelegateMethod("KG");
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            StyeleButtonFloor(btn0);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            StyeleButtonFloor(btn1);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            StyeleButtonFloor(btn3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            StyeleButtonFloor(btn4);
        }
    }
}
