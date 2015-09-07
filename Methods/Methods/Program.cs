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

            int result = 0;
            int counter = 0;
            while (counter <= n)
            {
                result = result + counter;
                counter++;

            }

            return result;
        }

        static int AddUp2(int n)
        {
            int res = 0, temp, count = 0;

            temp = n * 2;
            while(count <= temp)
            {
                if (count % 2 == 0)
                {
                  // res += count;
                    res = res + count; // is equivalent
                }
                count++;
            }
            
            return res;
        }
    }
}
