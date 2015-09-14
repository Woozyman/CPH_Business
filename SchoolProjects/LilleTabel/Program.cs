using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilleTabel
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Write a number: ");
            int.TryParse(Console.ReadLine(), out num);

            Console.WriteLine();

            LilleTabel(num, 10);

            Console.WriteLine();

            LilleTabelRev(num, 10);

            Console.WriteLine("Write String to reverse: ");
            RevStr(Console.ReadLine());

            Console.WriteLine("Write String to reverse2: ");
            RevStr2(Console.ReadLine());

        }

        public static void LilleTabel(int num, int divisibleBy)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % divisibleBy == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void LilleTabelRev(int num, int divisibleBy)
        {
            for (int i = num; i != 0; i--)
            {
                if (i % divisibleBy == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void RevStr(string str)
        {
            char[] revStr = str.ToCharArray();
            Array.Reverse(revStr);
            Console.WriteLine(revStr); 
        }

        public static void RevStr2(string str)
        {
            string revStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str.Substring(i, 1);
            }

            Console.WriteLine(revStr);
        }

    }
}



