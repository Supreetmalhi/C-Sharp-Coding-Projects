using System;
using System.Globalization;

namespace shipping_quote_for_a_package
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");

            int Wgt, Hgt, Len, Wdt;
            double Fnl_Dem;

            Wgt = Convert.ToInt32(Console.ReadLine());

            if (Wgt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package Width:");
                Wdt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                Hgt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package Length:");
                Len = Convert.ToInt32(Console.ReadLine());
                if ((Wdt + Hgt + Len) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Fnl_Dem = ((Wdt * Hgt * Len) * Wgt) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " + Fnl_Dem.ToString("C", CultureInfo.CurrentCulture));
                }
            }
        }
    }
}
