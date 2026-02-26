using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a non-negative number:");
            string number = Console.ReadLine();
            int n = int.Parse(number);
            int ndevide = n / 2;
            Console.WriteLine(ndevide);
            int nshift = n << 3;
            Console.WriteLine(nshift);
            int nXOR = n ^ 6;
            Console.WriteLine(nXOR);
            bool nsize = n > 10;
            Console.WriteLine(nsize);
        }
    }
}
