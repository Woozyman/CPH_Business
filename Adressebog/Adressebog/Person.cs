using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressebog
{
    class Person
    {


        public static int Id = 0;
        public PersonState State;
        private string name = "";
        private string address = "";
        private string country = "";
        private int zipCode = 0;
        private int personId;

        public Person()
        {
            this.personId = ++Id;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public string Adress
        {
            get { return address; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                   address = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    country = value;
                }
            }
        }

        public int PersonId
        {
            get
            {
                return personId;
            }
        }

        public int Zipcode
        {
            get
            {
                return zipCode;
            }
            set
            {
                this.zipCode = value;
            }
        }

    }

    enum PersonState
    {
        friend,
        enemy,
        happy,
        sad,
        hungry,
        horny
    };
}
