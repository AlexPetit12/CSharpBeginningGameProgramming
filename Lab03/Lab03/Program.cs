using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert fahrenheit to celsius
            float originalFahrenheit;

            // get fahrenheit temperature from user
            Console.WriteLine("Enter temperature in Fahrenheit: ");
            originalFahrenheit = float.Parse(Console.ReadLine());

            // convert fahrenheit to celsius
            float celsius = (originalFahrenheit - 32) * 5 / 9;

            // print result
            Console.WriteLine(originalFahrenheit + " degrees Fahrenheit is equivalent to " + celsius + " degrees Celsius.");
            Console.WriteLine();
        }
    }
}
