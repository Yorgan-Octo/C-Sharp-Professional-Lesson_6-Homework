using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLibrary
{
    internal class TemperatureConverter : ITConverter
    {

       public decimal CelsiusToFahrenheit(decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public decimal CelsiusToKelvin(decimal celsius)
        {
            return celsius + 273.15m;
        }

        public decimal FahrenheitToCelsius(decimal fahrenheit)
        {
            return (fahrenheit - 32) / 1.8m;
        }

        public decimal FahrenheitToKelvin(decimal fahrenheit)
        {
            return (fahrenheit + 459.67m) / 1.8m;
        }

        public decimal KelvinToCelsius(decimal kelvin)
        {
            return kelvin - 273.15m;
        }

        public decimal KelvinToFahrenheit(decimal kelvin)
        {
            return (kelvin - 273.15m) * 1.8m + 32;
        }







    }
}
