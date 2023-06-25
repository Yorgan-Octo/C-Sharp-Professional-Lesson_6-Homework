using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {

            Assembly assembly;



            try
            {
                assembly = Assembly.Load("TemperatureLibrary");
                Console.WriteLine("Библиотека импортованна");
            }
            catch (Exception)
            {
                throw;
            }


            Type element = assembly.GetType("TemperatureLibrary.TemperatureConverter");
            MethodInfo[] method = element.GetMethods();


            Console.WriteLine("---------------------");
            foreach (MethodInfo item in method)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("---------------------");

            MethodInfo convertToFahrenheit = element.GetMethod("CelsiusToFahrenheit");

            object instance = Activator.CreateInstance(element);
            object[] parameters = { 36m };

            decimal res =  (decimal)convertToFahrenheit.Invoke(instance, parameters);

            Console.WriteLine((decimal)parameters[0] + " цельсіїв в фаренгейтах буде " + res);

            Console.ReadKey();

        }
    }
}
