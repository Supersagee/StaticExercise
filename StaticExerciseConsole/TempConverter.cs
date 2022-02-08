using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExerciseConsole
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double userTemp)
        {
            return (userTemp - 32) * .5556;
        }

        public static double CelsiusToFahrenheit(double userTemp)
        {
            return (userTemp * 1.8) + 32; 
        }

    }
}
