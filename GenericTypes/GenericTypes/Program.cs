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
            var sum = new AddSomething<double>();
            var str = new AddSomething<string>();
            sum.print(25);
            str.print("this string");
        }
    }
}
