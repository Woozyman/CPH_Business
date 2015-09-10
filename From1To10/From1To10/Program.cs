using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1To10
{
    /// <summary>
    /// Skriver tallene fra 1 - 10 til Console.
    /// først med et while loop
    /// derefter med et for loop
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num != 11) 
            {
                Console.WriteLine(num);
                num++; // samme som : num = num + 1;
            }

            Console.WriteLine("Tryk på en tast for at skrive tallene med et for loop");
            Console.ReadLine(); 

            Console.WriteLine("=============================================================");

            for (num = 1; num < 11; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine(); // kommenter evt dette statement ud og kør programmet
                                // ved at trykke alt + F5. det giver samme resultat.
        }
    }
}
