using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            for (int i = 0; i < 3; i++)
            {
                Animal A1 = new Animal();
                Console.Write("Please enter the animals type: ");
                A1.Type = Console.ReadLine();
                Console.Write("Please enter the animals name: ");
                A1.Name = Console.ReadLine();
                Console.Write("Please enter the animals age: ");
                A1.Age = int.Parse(Console.ReadLine());
                Console.Write("Please enter the animals ID: ");
                A1.ID = int.Parse(Console.ReadLine());
                Console.WriteLine(A1.Details());
                animals[i] = A1;
            }

            Console.ReadLine();
            // A1 will get overwritten - create array to store values.
        }
    }

    class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string Details()
        {
            return $"\nAnimal Details...\n" +
                   $"Type = {Type}\n" +
                   $"Name = {Name}\n" +
                   $"Age = {Age}\n" +
                   $"ID = {ID}\n";
        }
    }
}
