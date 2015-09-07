using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

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

            Person p3 = new Person();
            p3.Name = "Michael";
            p3.State = PersonState.hungry;

            Person p4 = new Person("Tue");
            Console.WriteLine(p4.Name);
            Console.WriteLine(p4.PersonId);

            

                      

               






        }
    }
}
