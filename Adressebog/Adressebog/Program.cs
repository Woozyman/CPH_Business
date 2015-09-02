using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressebog
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Name = "Frey";
            p1.State = PersonState.happy;
            Console.WriteLine("id:  {0} Name: {1} State: {2} ", p1.PersonId, p1.Name, p1.State);


            Person p2 = new Person();
            p2.State = PersonState.friend;
            p2.Name = "Jens";
            Console.WriteLine("id:  {0} Name: {1} State: {2} ", p2.PersonId, p2.Name, p2.State);
        }
    }
}
