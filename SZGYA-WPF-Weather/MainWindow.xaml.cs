using System.IO;
using System.Text;
using System.Threading;
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
            var sr = new StreamReader("../../../src/cities.txt");
            _ = sr.ReadLine(); // skip 1st line
            while (!sr.EndOfStream) cities.Add(new City(sr.ReadLine(), ","));

            lstbxCityWeatherData.ItemsSource = cities;
            lstbxCityWeatherData.SelectedItem = cities.FirstOrDefault();
        }

        private void btnAddCityClick(object sender, RoutedEventArgs e)
        {
            cities.Add(new City() { Name = txbCityName.Text, Humidity = float.Parse(txbHumidity.Text), Windspeed = float.Parse(txbWindSpeed.Text), Temperature = float.Parse(txbTemp.Text)});
            lstbxCityWeatherData.Items.Refresh();
        }

        private void btnDeleteClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cities.Remove((City)b.DataContext);
            lstbxCityWeatherData.Items.Refresh();
        }

        private void lstbxCityWeatherDataSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (City c in cities) c.showExtendedData = false;
            if (lstbxCityWeatherData.SelectedItem != null) ((City)lstbxCityWeatherData.SelectedItem).showExtendedData = true;
            lstbxCityWeatherData.Items.Refresh();
        }

        private void btnModifyCityClick(object sender, RoutedEventArgs e)
        {

        }
    }
}