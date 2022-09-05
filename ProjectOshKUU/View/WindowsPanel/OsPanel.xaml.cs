using OshKUU.ViewModels;
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
using System.Windows.Shapes;

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для OsPanel.xaml
    /// </summary>
    public partial class OsPanel : Window
    {
        public OsPanel()
        {
            InitializeComponent();
            //this.DataContext = new OsPanelVM();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("1");
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("2");
            this.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("3");
            this.Close();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("4");
            this.Close();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("5");
            this.Close();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            StaticLanguageClass.SelectBuildingMethod("6");
            this.Close();
        }
    }
}
