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
    /// Логика взаимодействия для AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextNumer.Text == "940707")
            {
                StaticLanguageClass.AccessAccount = true;
                this.Close();
            }
            else
            {
                StaticLanguageClass.AccessAccount = false;
                MessageBox.Show("Не правильный пароль!");
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
