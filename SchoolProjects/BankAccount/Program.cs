﻿namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank a = new Bank("Freys Bank");
            Bank b = new Bank("");

            a.streetAdd = "Amagerfælledvej 47";

            a.Print();
            b.name = "New Bank Name";
            b.Print();
            


        }
    }
}
