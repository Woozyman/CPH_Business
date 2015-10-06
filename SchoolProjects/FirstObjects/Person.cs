using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjects
{
    class Person
    {
        string fName = "Frey";
        string lName;
        DateTime birthDay;


        public Person() { }
        public Person(string fName)
        {
            this.fName = fName;
        }
        public void Print()
        {
            Console.WriteLine(fName);
        }
        

        public string Fname
        {
            get { return fName; }
            set
            {
                if (value != fName)
                {
                    fName = value;
                }
                else
                {
                    Console.WriteLine("Name is the same as before. Try again!");
                }
               
            }
        }

        public string Lname
        {
            get { return lName; }
            set
            {
                if (value != lName)
                {
                    lName = value;
                }
                else
                {
                    Console.WriteLine("Last Name is the same as before. Try again!");
                }

            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }

            set
            {
                birthDay = value.ToLocalTime();
            }
        }
    }
}
