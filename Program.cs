using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD");
            int num1, num2, num3;
            Console.WriteLine("Enter the numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greatest.");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greatest.");
            }
            else
            {
                Console.WriteLine("num3 is greatest.");
            }

            Console.ReadLine();
        }
    }
}