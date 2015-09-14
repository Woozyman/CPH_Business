using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeBricks
{
    class Program
    {
        

        public static bool MakeBricks()
        {
            double small, big, goal, numSmall, numBig, result;

            Console.WriteLine("Write no small bricks: ");
            double.TryParse(Console.ReadLine(), out small);
            Console.WriteLine("Write no big bricks: ");
            double.TryParse(Console.ReadLine(), out big);
            Console.WriteLine("Write goal value: ");
            double.TryParse(Console.ReadLine(), out goal);

            numBig = Math.Abs((goal - (goal % 5)) / 5);
            numSmall = Math.Abs((goal % 5) );
            
                       
            Console.WriteLine("Small: {0} ", goal % 5);
            Console.WriteLine("Big: {0} ", (goal - (goal % 5)));
            Console.WriteLine("needs numSmall: {0}", numSmall);
            Console.WriteLine("needs numBig: {0}", numBig);
            result = (numBig * 5) + numSmall;
            Console.WriteLine("result: {0}", result);

            if ((goal > big * 5 + small || goal % 5 > small))
            {
                return false;
            }
            else if (goal == 0)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                if (MakeBricks())
                {
                    Console.WriteLine("True - Congrats... Go build a house!");
                }
                else
                {
                    Console.WriteLine("False - Not enough Bricks");
                }
            }
           
            
        }

        
    }
}
