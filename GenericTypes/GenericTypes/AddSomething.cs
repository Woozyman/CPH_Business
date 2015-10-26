using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TestSomething<T,S>
    {
     
        public void print(T thing)
        {
            Console.WriteLine(thing);
        }
        
        public void Concat(T a, S b)
        {
            Console.WriteLine("{0}{1}",a, b);
        }

        public bool CheckifEqual(T str1, S str2)
        {
            string tempStr1 = str1.ToString();
            string tempStr2 = str2.ToString();
            if (tempStr1 != tempStr2)
            {
                return false;
            }
            else
            {
                return true;
            }
                       
        }

    }
}
