using System;
using static System.Math;

namespace FirstObjects
{
    class Person
    {
        //TODO Make a string to hold birthday after DateTime Conversion


        string fName = "Frey";
        string lName;
        DayOfWeek presentDay { get; set; } = DateTime.Today.DayOfWeek;
        DateTime birthDay;

        public double X { get; set; } = 4;
        public double Y { get; set; } = 2;

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

        public double GetRoot => Sqrt(X * Y);
        //public new string ToString() => $"{X}, {Y}";
        public override string ToString() => $"{X}, {Y}";

        public string ReturnStr => string.Format("{0}, {1}", X, Y);

        public DayOfWeek GetDay => presentDay;

    }
}
