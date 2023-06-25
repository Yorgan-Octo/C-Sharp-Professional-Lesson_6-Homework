using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLibrary
{
    internal class TemperatureCelsiusBox : IFormattable
    {

        private decimal temperature;

        public decimal Celsius
        {
            get { return temperature; }
        }
        public decimal Fahrenheit
        {
            get { return temperature * 9 / 5 + 32; }
        }
        public decimal Kelvin
        {
            get { return temperature + 273.15m; }
        }

        public TemperatureCelsiusBox(decimal temperature)
        {
            this.temperature = temperature;
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";

            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format)
            {
                case "C":
                case "G":
                    return temperature.ToString("F2", formatProvider) + "°C";
                case "F":
                    return temperature.ToString("F2", formatProvider) + "°F";
                case "K":
                    return temperature.ToString("F2", formatProvider) + "°K";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }


        }

        public void AddCelsius(decimal celsius)
        {
            temperature += celsius;
        }

        public void SumCelsius(decimal celsius)
        {

            if ((temperature + celsius) >= -273)
            {
                temperature += celsius;
            }

            throw new Exception("Температура ниже абсольтного нуля!");
        }

    }
}
