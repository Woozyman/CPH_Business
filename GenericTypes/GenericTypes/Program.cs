using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum  = new TestSomething<double,float>();
            var sum2 = new TestSomething<double, double>();
            var strNum  = new TestSomething<string, int>();
            var tStr = new TestSomething<string, string>();
            sum.print(25);
            strNum.print("this string");
            sum.Concat(25.012, 250);
            strNum.Concat("Frey", 31);

            Console.WriteLine(tStr.CheckifEqual("Frey", "frey"));
            Console.WriteLine(sum2.CheckifEqual(1.234, 1.234));
            Console.WriteLine(strNum.CheckifEqual("1234", 1234));
            Console.WriteLine(sum.CheckifEqual(1.123,1.123f));

            
        }
    }
}
