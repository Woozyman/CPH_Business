using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tobias", "Grundtvig", 42);
            Console.WriteLine("Reference: " + p);
            Console.WriteLine("First name: " + p.getFirstName());
            Console.WriteLine("Last name: " + p.getLastName());
            Console.WriteLine("Age: " + p.getAge());
            p.Birthday();
            Console.WriteLine("Name: " + p.getFullName());
            Console.WriteLine("Age: " + p.getAge());
        }
    }
}
