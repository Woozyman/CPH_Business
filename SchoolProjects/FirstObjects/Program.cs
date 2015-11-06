using System;

namespace FirstObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Thomas");
            Person p2 = new Person();
           
                Console.Write("Write your name: ");
                p1.Fname = Console.ReadLine();
                p1.Print();
           
            string test1 = "13-01-1984";
            string test2 = "10-02-1984";

            p1.BirthDay = DateTime.Parse(test1);
            p2.BirthDay = DateTime.Parse(test2);
           

            DateTime now = new DateTime();
            now = DateTime.Now;
            string calculateDiff = (p1.BirthDay - p2.BirthDay).TotalDays.ToString();
            calculateDiff = calculateDiff.Substring(1, calculateDiff.Length - 1);

            if (p1.BirthDay == p2.BirthDay)
            {
                Console.WriteLine("You have the same Birthday");
            }
            else
            {
                Console.WriteLine("You don't have the same Birthday");
            }

            if (p1.BirthDay < p2.BirthDay)
            {
                Console.WriteLine("p1 is older");
                Console.WriteLine("p1 is {0} days older than p2", calculateDiff );
            }
            else
            {
                Console.WriteLine("p2 is older");
            }
            Console.WriteLine();

            Console.WriteLine(p2.GetRoot);
            //Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.ReturnStr);
            p2.X = 7;
            p2.Y = 11;

            Console.WriteLine(p2.GetRoot);
            //Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.ReturnStr);
            Console.WriteLine(p2.GetDay);
        }
    }
}
