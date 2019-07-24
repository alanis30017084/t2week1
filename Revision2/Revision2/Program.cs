using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q6 Circle calculations

            Console.Write("Enter a number for the radius: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter = {Perimeter(r)}\n Area = {Area(r)}");
            Console.ReadLine();

            // Q7 Swapping Variables

            int a = 10;
            int b = 20;
            int c;
            Console.WriteLine("A = {a} B = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("A = {a} B = {b}");
            Console.ReadLine();

            // Q8 Array

            

        }

        // Q6 Methods
        static double Perimeter(double r)
        {
            return 2 * Math.PI * r;
        }

        static double Area(double r)
        {
            return Math.PI * (r * r);
        }

        
    }
}
