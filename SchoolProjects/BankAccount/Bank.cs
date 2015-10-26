using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TODO Write Fields and Methods to describe a Bank

namespace BankAccount
{
    class Bank
    {
        public string name { get; set; } = "MyBank";
        public string streetAdd = "MyStreet";
        string error { get; } = "Invalid String, String must not be empty";
        int bankId;

        static int id = 0;


        public Bank(string inName)
        {

            try
            {
                if (inName != string.Empty && inName != "" && inName != " ")
                {
                    name = inName;
                    Console.WriteLine("Bank Constructed");
                    bankId = id;

                }
                else
                {
                    throw new Exception(error);

                }



            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            id++;
        }

        public void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("id: " + bankId + "\n");
            sb.Append("Name: " + name + "\n");
            sb.Append("Address: " + streetAdd);
            Console.WriteLine(sb.ToString());

        }
    }
}
