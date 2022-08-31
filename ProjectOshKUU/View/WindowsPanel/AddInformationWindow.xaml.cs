using OshKUU.Models;
using ProjectOshKUU.Data.Services.AbstractServices;
using System.Windows;
using System.Linq;
using System.Threading.Tasks;
using ProjectOshKUU.Data;

namespace ProjectOshKUU.View.WindowsPanel
{
    /// <summary>
    /// Логика взаимодействия для InformationFlat.xaml
    /// </summary>
    public partial class AddInformationWindow : Window
    {
        private string _head { get; set; }
        private string _Content { get; set; }
        private readonly IAudienceService _service;

        private int _floor;
        private int _building;
        private int _numberFlat;
        public AddInformationWindow(int floor, int building, int numberFlat, IAudienceService service)
        {
            _floor = floor;
            _building = building;
            _numberFlat = numberFlat;
            _service = service;
            InitializeComponent();

        }




        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextInformation.Text != "" && TextHead.Text != "" && TextNumer.Text != "")
            {
                // _context = new AppDbContext();
                Audience _Audiencedata = await _service.GetFirstOrDefaultAsync(_floor, _building, _numberFlat, "KG");
                Audience audience = new();
                audience.InfoAudit = TextInformation.Text;
                audience.Name = TextHead.Text;
                audience.NumberAudit = TextNumer.Text;
                audience.Number = _numberFlat;
                audience.Floor = _floor;
                audience.Lang = "KG";
                audience.Building = _building;
                if (_Audiencedata != null)
                {
                    _Audiencedata.InfoAudit = TextInformation.Text;
                    _Audiencedata.Name = TextHead.Text;
                    _Audiencedata.NumberAudit = TextNumer.Text;
                    await _service.UpdateAsync(_Audiencedata.Id, _Audiencedata);
                }
                else
                    await _service.AddAsync(audience);
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните кыргызкий язычный часть информационных полей!");
            }
            if (TextInformation2.Text != "" && TextHead2.Text != "" && TextNumer2.Text != "")
            {
                Audience _Audiencedata2 = await _service.GetFirstOrDefaultAsync(_floor, _building, _numberFlat, "RU");
                Audience audience2 = new();
                audience2.InfoAudit = TextInformation2.Text;
                audience2.Name = TextHead2.Text;
                audience2.Number = _numberFlat;
                audience2.NumberAudit = TextNumer2.Text;
                audience2.Floor = _floor;
                audience2.Lang = "RU";
                audience2.Building = _building;
                if (_Audiencedata2 != null)
                {
                    _Audiencedata2.InfoAudit = TextInformation2.Text;
                    _Audiencedata2.Name = TextHead2.Text;
                    _Audiencedata2.NumberAudit = TextNumer2.Text;
                    await _service.UpdateAsync(_Audiencedata2.Id, _Audiencedata2);
                }
                else await _service.AddAsync(audience2);
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните русскоязычную часть информационных полей!");
            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
