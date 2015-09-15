using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutReferences
{
    class Program
    {
        static string promtName = "Write your name: ";
        static string promtAge = "Write your age: ";
        static string name;
        static int age;
        static void Main(string[] args)
        {
            readPerson(out name, out age);

            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Age is: " + age);
        }

        static void readPerson(out string name, out int age)
        {
            Console.Write(promtName);
            name = Console.ReadLine();
            Console.Write(promtAge);
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
        }
    }
}
