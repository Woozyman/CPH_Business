using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueOrReference
{
    class Program
    {
        static int myInt = 0;
        static double myDouble = 0;


        static void Main(string[] args)
        {
            Console.WriteLine("myDouble before passing by value: {0}", myDouble);
            Console.WriteLine();
            Console.WriteLine("myInt before passing by reference: {0}", myInt);

            PassByValue(myDouble);
            PassByReference(ref myInt);

            Console.WriteLine();

            Console.WriteLine("myDouble after passing by value: {0}", myDouble);
            Console.WriteLine();
            Console.WriteLine("myInt after passing by reference: {0}", myInt);

            Console.WriteLine();

            for (double i = myDouble; i < 10; i++)
            {
                Console.WriteLine("myDouble after passing by value: {0}", myDouble);
            }

            Console.WriteLine();

            for (int i = myInt; i < 10; i++)
            {
                PassByReference(ref myInt); Console.WriteLine("myInt after passing by reference: {0}", myInt);
            }

           
        }

        static void PassByValue(double i)
        {
            i++;
        }
        static void PassByReference(ref int i)
        {
            i++;
        }
    }
}
