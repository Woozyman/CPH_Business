using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 10;
                int* ptr = &i;
                Console.WriteLine((int)ptr);
            }

            Console.ReadLine();  

        }
    }
}
