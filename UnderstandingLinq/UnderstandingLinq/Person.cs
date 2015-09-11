using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLinq
{
    class Person
    {
        public Person()
        {
            id++;
        }
        public static int id = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BornYear { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }

        
    }
}
