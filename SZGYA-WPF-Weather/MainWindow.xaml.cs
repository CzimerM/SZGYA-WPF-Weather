using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SZGYA_WPF_Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<City> cities;

        public MainWindow()
        {
            InitializeComponent();
            cities = new List<City>();
            cities.Add(new City() { Name = "Bivalyb*sznád", Humidity = 10f, Windspeed = 20.1f, Temperature = 20f });

            lstbxCityWeatherData.ItemsSource = cities;
        }

        private void btnAddCityClick(object sender, RoutedEventArgs e)
        {

        }
    }
}