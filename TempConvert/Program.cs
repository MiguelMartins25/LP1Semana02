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
            double temperaturedub = double.Parse(temperature);
            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();
            switch (unit)
            {
                case "C":
                    double temperatureconv = temperaturedub * 1.8 + 32;
                    Console.WriteLine(temperaturedub + " C = " + temperatureconv + " F");
                    break;

                case "F":
                    double temperatureconv2 = (temperaturedub - 32)/1.8;
                    Console.WriteLine(temperaturedub + " F = " + temperatureconv2 + " C");
                    break;

                default:
                    Console.WriteLine("Invalid unit.");
                    break;
            }
            Console.Write("Absolute value: ");
            double absolutetemp = Math.Abs(temperaturedub);
            Console.WriteLine(absolutetemp);
        }
    }
}
