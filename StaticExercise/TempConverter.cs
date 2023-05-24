using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double Fahrenheit { get; set; }
        
        public static double Celcius { get; set; }  
        public static void FahrenheitToCelcius()
        {
            Console.WriteLine("Enter your fahrenheit temperature");
            double fahrenheit = Convert.ToDouble(Console.ReadLine()); 
            double celcius = (fahrenheit - 32) / 1.8;
            Console.WriteLine($"Your temperature in celcius is {celcius}");



        }

        public static void CelciusToFarenheit()
        {
            Console.WriteLine("Enter your celcius temperature");  
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine($"Your temperature in fahrenheit is {fahrenheit}");

        }

    }
}
