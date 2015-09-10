using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Employee
    {
        private string name;
        private int age;
        private static int id = -1;
        private static int id2 = 5;

        public Employee()
        {
            
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }

        }

        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }

        }

        public static int Id()
        {
            id++;
            return id;
        }

        public static int Id2()
        {
            id2--;
            return id2;
        }

    }
}
