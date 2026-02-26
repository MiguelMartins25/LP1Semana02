using System.Globalization;
using System;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            string temperature = Console.ReadLine();
            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();
        }
    }
}
