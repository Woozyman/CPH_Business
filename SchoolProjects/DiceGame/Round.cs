using System.Collections.Generic;
using System.Text;

namespace DiceGame
{
    public class Round
    {

        List<int[]> diceThrowList = new List<int[]>();
        public static int roundNum = 1;
        public static int round;
        public int roundResult { get; set; }
        public int[] roundRes = new int[6];
        

        public static int numOfRolls { get; set; } = 0;

        public Round()
        {
            round = roundNum - 1;
        }

        public void UpdateThrowList(int[] throwResults)
        {
            diceThrowList.Add(throwResults);
        }

        //public void PrintThrowResults()
        //{
        //    System.Console.Write("Round {0} Throws: ", roundNum);
        //    foreach (var item in diceThrowList)
        //    {
        //        for (int i = 0; i < item.Length; i++)
        //        {
        //            System.Console.Write(item[6i] + ", ");
        //        }
        //    }
        //}

        public string ThrowString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i != diceThrowList[round].Length; i++)
            {
                sb.Append(diceThrowList[round][i]);
            }

            return sb.ToString();
        }


        
    }
}
