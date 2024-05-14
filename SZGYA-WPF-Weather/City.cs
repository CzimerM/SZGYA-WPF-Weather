using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SZGYA_WPF_Weather
{
    internal class City
    {
        public string? Name { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Windspeed { get; set; }

        public bool showExtendedData { get; set; } = false;

        public Visibility Visibility
        {
            get { return showExtendedData ? Visibility.Visible : Visibility.Collapsed; }
        }

        public City(string line, string separator)
        {
            string[] data = line.Split(separator);
            Name = data[0].Trim('"');
            Temperature = float.Parse(data[1].Replace('.',','));
            Humidity = float.Parse(data[2].Replace('.', ','));
            Windspeed = float.Parse(data[3].Replace('.', ','));
        }

        public City() { }
    }
}
