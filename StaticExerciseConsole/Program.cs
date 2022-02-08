using System;

namespace StaticExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(84));
            
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(33));
           
        }
    }
}
