using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Q4
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Q1(name));
            Console.WriteLine(Q2(num1, num2));
            Console.WriteLine(Q3(num1, num2));
            Console.WriteLine(Q4(num1, num2));
        

            // Q5 Multiplication Table

            Console.Write("\nEnter a number: ");
            int num = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
          
            Console.ReadLine();


        }

        static string Q1(string name)
        {
            return $"\nHello\n{name}";
        }

        static string Q2(int num1, int num2)
        {
            return $"{num1} + {num2} = {num1 + num2}";
        }

        static string Q3(int num1, int num2)
        {
            return $"{num1} / {num2} = {num1 / num2}";
        }

        static string Q4(int num1, int num2)
        {
            return $"{num1} x {num2} = {num1 * num2}";
        }
    }
}
