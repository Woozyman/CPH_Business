using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number to AddUp() Function: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result is: {0} ", AddUp(num));
                                             
        }

        static int AddUp(int n)
        {
            //int result = 0;
            //for (int i = 0; i <= n; i++)
            //    result += i;
            //return result;

            int result = 0;
            int counter = 0;
            while (counter <= n)
            {
                result = result + counter;
                counter++;

            }

            return result;
        }
    }
}
