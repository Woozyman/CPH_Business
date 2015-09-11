using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myPersons = new List<Person>() {
                new Person() {FirstName = "Frey", LastName = "Clante", BornYear = 1984, Height = 188, Gender = "Male" },
                new Person() { FirstName = "Michael", LastName = "Hansen", BornYear = 1983, Height = 194, Gender = "Male" },
                new Person() {FirstName = "Riza", LastName = "Clante", BornYear = 1982, Height = 158, Gender = "Female" },
                new Person() {FirstName = "Helle", LastName = "Voss", BornYear = 1959, Height = 166, Gender = "Female" },
                new Person() {FirstName = "Jesper", LastName = "Clante", BornYear = 1954, Height = 190, Gender = "Male" },
                new Person() {FirstName = "Jens", LastName = "Kolby", BornYear = 1967, Height = 175, Gender = "Male" }
            };

            //var byGender = from person in myPersons
            //                  where person.Gender == "Male"
            //                  select person;

            var byYearOfBirth = from person in myPersons
                                orderby person.BornYear descending
                                select new { person.FirstName, person.BornYear, person.Gender};

            foreach (var person in byYearOfBirth)
            {
                Console.WriteLine("{0} - {1} - {2}", person.FirstName, person.BornYear, person.Gender);
            }
        }
    }
}
