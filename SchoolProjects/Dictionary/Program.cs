using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Person> dic = new Dictionary<int, Person>();
            Dictionary<string, Person> dic2 = new Dictionary<string, Person>();

            Person p1 = new Person("Frey");
            Person p2 = new Person("Leon");

            dic.Add(p1.PersonId, p1);
            dic.Add(p2.PersonId, p2);

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value.Name);
            }

            dic2.Add("Frey", new Person());
            dic2.Add("Leon", new Person());

            foreach (var item in dic2)
            {
                Console.WriteLine(item.Key + " " + item.Value.PersonId);
            }

            if (dic2.ContainsKey("Leon"))
            {
                Console.WriteLine("Key Leon Exists");
            }

            Console.WriteLine("Delete Dictionary");

            dic.Clear();
            Console.WriteLine();

            Console.WriteLine("");
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value.Name);
            }




        }
    }
}
