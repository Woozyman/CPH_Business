using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjects
{
    class Program
    {

        public void MyFunc()
        {
            Console.WriteLine("Test");
        }

        static void Main(string[] args)
        {
            String name = "Ludvig Hartmann";

            for (int i = 0 ; i < name.Length; i++)
            {
                Console.WriteLine(name.Substring(i,1));
            }

            Console.WriteLine();

            for (int i = name.Length; i > 0; i--)
            {
                Console.WriteLine(name.Substring(i-1, 1));
            }

            Console.WriteLine();

            for (int i = 0; i < name.Length; i++)
            {
                if ('n' == char.Parse(name.Substring(i, 1)))
                {
                    Console.WriteLine(name.Substring(i, 1));
                }
            }

                        
        }

       
    }
}
