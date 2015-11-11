using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Soft-Dices Game------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Write Numbers of Players: ");
            DiceGame dg = new DiceGame(int.Parse(Console.ReadLine()));

            List<Player> pList = new List<Player>();

            for (int i = 1; i <= dg.numOfPlayers; i++)
            {
                pList.Add(new Player());
            }

        }
    }
}
