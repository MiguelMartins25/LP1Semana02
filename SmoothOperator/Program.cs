using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            string number = Console.ReadLine();
            sbyte n = sbyte.Parse(number);
            sbyte nplus = n++;
            Console.WriteLine(nplus);
            sbyte nminus = n--;
            Console.WriteLine(nminus);
        }
    }
}
