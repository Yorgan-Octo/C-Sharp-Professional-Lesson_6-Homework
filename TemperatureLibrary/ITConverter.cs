using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLibrary
{
    internal interface ITConverter
    {


        /// <summary>
        /// переводить температуру в цельсіях в фаренгейти
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        decimal CelsiusToFahrenheit(decimal celsius);

        /// <summary>
        /// переводить температуру в цельсіях в кельвіни
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        decimal CelsiusToKelvin(decimal celsius);

        /// <summary>
        /// переводить температуру в фаренгейтах в цельсій
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        decimal FahrenheitToCelsius(decimal fahrenheit);

        /// <summary>
        /// переводить температуру в фаренгейтах в кельвіни
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        decimal FahrenheitToKelvin(decimal fahrenheit);

        /// <summary>
        /// переводить температуру в фаренгейтах в цельсій
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        decimal KelvinToCelsius(decimal kelvin);

        /// <summary>
        /// переводить температуру в фаренгейтах в кельвіни
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        decimal KelvinToFahrenheit(decimal kelvin);

    }
}
