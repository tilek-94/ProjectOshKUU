using System.Windows;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtHead.Text = _head;
            txtContent.Text = _Content;
        }
    }
}
