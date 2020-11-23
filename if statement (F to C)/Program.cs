using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            double celsius;
            Console.Write("Enter temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + celsius);
            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");
            Console.ReadLine();










        }
    }
}