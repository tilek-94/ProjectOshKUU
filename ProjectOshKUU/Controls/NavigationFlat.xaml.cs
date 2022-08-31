using ProjectOshKUU.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ProjectOshKUU.Controls
{
    /// <summary>
    /// Логика взаимодействия для NavigationFlat.xaml
    /// </summary>
    public partial class NavigationFlat : UserControl
    {
        public NavigationFlat()
        {
            InitializeComponent();
            StaticLanguageClass.LanguageDelegate -= NavigationMethod;
            StaticLanguageClass.LanguageDelegate += NavigationMethod;
            //NavigationMethod();
        }
        private void NavigationMethod()
        {
            if(StaticLanguageClass.Lang=="RU")
            btn2.Uid = "Туалет";
            else
            btn2.Uid = "Ажат кана";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*WebBrowsers webBrowsers = new WebBrowsers("https://goo.gl/maps/ERkXv2ZwYFvvGR7U8");
            webBrowsers.ShowDialog();*/
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*LoadWindow loadWindow = new LoadWindow();
            loadWindow.ShowDialog();*/
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
