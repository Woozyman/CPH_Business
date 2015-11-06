using System;

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
