using ProjectOshKUU.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для SaitUniversitet.xaml
    /// </summary>
    public partial class SaitUniversitet : UserControl
    {
        public SaitUniversitet()
        {
            InitializeComponent();
            
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                try
                {
                    Process[] arrPro = Process.GetProcessesByName("ProjectOshKUU");
                    foreach (Process pro in arrPro)
                        pro.Kill();
                    StaticLanguageClass.SelectBuildingMethod("main");
                }
                catch
                {

                }
            
           
        }
    }
}
