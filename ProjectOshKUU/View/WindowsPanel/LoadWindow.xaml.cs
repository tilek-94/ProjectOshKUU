using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WpfAnimatedGif;

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для LoadWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        public LoadWindow()
        {
            InitializeComponent();
        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Personto_to_walk();
            timer.Interval = TimeSpan.FromSeconds(4);
            timer.Tick += Time;
            timer.Start();

        }
        public void Time(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
        public void Personto_to_walk()
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("/Image/Building/loading-load.gif", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(imageAwesome, image);
            ImageBehavior.SetRepeatBehavior(imageAwesome, new System.Windows.Media.Animation.RepeatBehavior());
        }
    }
}
