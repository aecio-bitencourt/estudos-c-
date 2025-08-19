using System;
using System.Globalization;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            var n = int.Parse(Console.ReadLine());
            var products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.WriteLine();
            }
        }
    }
}