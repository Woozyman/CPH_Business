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
            int num;
            if(int.TryParse(Console.ReadLine(), out num))
            

            if(num != 0)
            Console.WriteLine("Result is: {0} ", AddUp(num));


            Console.WriteLine("Type in a number to AddUp2() Function: ");
            if (int.TryParse(Console.ReadLine(), out num))


                if (num != 0)
                    Console.WriteLine("Result is: {0} ", AddUp2(num));


        }

        static int AddUp(int n)
        {
            //int result = 0;
            //for (int i = 0; i <= n; i++)
            //    result += i;
            //return result;
            //==============================================================
            //int result = 0;
            //int counter = 0;
            //while (counter <= n)
            //{
            //    result = result + counter;
            //    counter++;

            //}

            //return result;
            return (n * (n + 1)) / 2;
        }

        static int AddUp2(int n)
        {
            int result = 0, doubleUp, count = 0;

            doubleUp = n * 2;
            while (count <= doubleUp)
            {
                if (count % 2 == 0)
                {
                    // res += count;
                    result = result + count; // is equivalent
                }
                count++;
            }

            return result;

            //return 2 * AddUp(5);
        }

        static int Times(int a, int b)
        {
            int res = 0;
            while (a > 0)
            {
                res = res + b;
                a = a - 1;
            }

            return res;
        }
    }
}
