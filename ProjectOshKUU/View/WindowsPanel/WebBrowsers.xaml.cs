using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для WebBrowsers.xaml
    /// </summary>
    public partial class WebBrowsers : Window
    {
        string url;
        public WebBrowsers(string _url)
        {
            InitializeComponent();
            Browser.Navigated += (sender, args) => { HideScriptErrors((WebBrowser)sender, true); };
            url = _url;
            Browser.Source = new Uri(_url);
        }
        public void HideScriptErrors(WebBrowser wb, bool Hide)
        {
            FieldInfo fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;
            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { Hide });
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Zaderjka();
           

        }
       
        public  void Zaderjka()
        {
            
            Application.Current.Dispatcher.Invoke(() =>
            {
                LoadWindow loadWindow = new LoadWindow();
                loadWindow.Owner = this;
                loadWindow.ShowDialog();
            });
        }

    }
}
