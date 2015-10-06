using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimentionalArrays
{
    class Program
    {/// <summary>
    /// Prints a 2D integer Array to the console.
    /// Resizes the rows automatically to match length of integer.
    /// Prints the sum total for every row and column.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
           int[,] arr2D0 = new int[5, 7]
           {
                {1,2,3,4,5,6,0},
                {1,2,3000,4,5,6,0},
                {1,2,3,4,5,6,0},
                {1,2,3,4,50000,6,0},
                {0,0,0,0,0,0,0 }
           };

          
            Print2D(arr2D0, FindLongestElement(arr2D0));

            Console.ReadLine();  
        }

        static int FindLongestElement(int[,] arr)
        {
            int y = arr.GetLength(0);
            int x = arr.GetLength(1);
            string resStr = "";
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (arr[i,j].ToString().Length > resStr.Length)
                    {
                        resStr = arr[i, j].ToString();
                    }
                    
                }
            }
                       
            return resStr.Length;
        }


        static int[] Sum2DX(int[,] arr)
        {

            int y = arr.GetLength(0);
            int x = arr.GetLength(1);
            int[] res = new int[y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    res[j] += arr[j, i];
                }
            }

            return res;
        }

        static int[] Sum2DY(int[,] arr)
        {

            int y = arr.GetLength(0);
            int x = arr.GetLength(1);
            int[] res = new int[x];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x-1; j++)
                {
                    res[j] += arr[i, j];
                }

            }

            return res;
        }

        static void Print2D(int[,] arr, int cellSpacing)
        {

            int y = arr.GetLength(0);
            int x = arr.GetLength(1);

            int[] resX = new int[x];
            int[] resY = new int[y];
            resX = Sum2DX(arr);
            resY = Sum2DY(arr);


            char separator = '|';


            PrintFrame(cellSpacing, x);

            for (int i = 0; i < y - 1; i++)
            {

                for (int j = 0; j < x - 1; j++)
                {

                    if (arr[i, j].ToString().Length < cellSpacing && j != x - 1)
                    {
                        Console.Write(separator + arr[i, j].ToString().PadRight(cellSpacing));
                    }
                    else if (arr[i, j].ToString().Length == cellSpacing && j <= x && j != x - 1)
                    {
                        Console.Write(separator + arr[i, j].ToString().PadRight(cellSpacing));
                    }
                    else if (arr[i, j].ToString().Length <= cellSpacing)
                    {
                        Console.Write(separator + arr[i, j].ToString().PadRight(cellSpacing));
                    }
                      System.Threading.Thread.Sleep(100); //Print every 100mS
                    
                }
                Console.Write(separator);
                Console.Write(resX[i].ToString().PadRight(cellSpacing) + separator);  // Prints Horisontal results for each row
                Console.WriteLine();

                PrintFrame(cellSpacing, x);
            }

            // Prints Vertical results for each column
            for (int i = 0; i < resY.Length - 1; i++)
            {
                System.Threading.Thread.Sleep(100); //Print every 100mS
                arr[y-1, i] += resY[i];
                Console.Write(separator + arr[y-1, i].ToString().PadRight(cellSpacing));
            }
            Console.Write(separator + MakeEmptyString(cellSpacing +1) + separator);
            Console.WriteLine();
            PrintFrame(cellSpacing, x);
        }

       
                              
           
      

        private static void PrintFrame(int cellSpacing, int x)
        {
            char frameChar = '-';
            char[] frame = new char[x * cellSpacing + x + 1];

            for (int i = 0; i <= frame.Length - 1; i++)
            {
                frame[i] = frameChar;
                Console.Write(frame[i]);

            }
            Console.WriteLine();
        }

        private static void PrintRowSeparator(int cellspacing, int nElements)
        {
            char separatorUnder = '-';
            for (int i = 0; i < cellspacing * nElements + cellspacing ; i++)
            {
                Console.Write(separatorUnder);
            }
            Console.WriteLine();
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int SumArray(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }

            return res;
        }

        static string MakeEmptyString(int length)
        {

            StringBuilder emptyStr = new StringBuilder();

            for (int i = 0; i < length - 1; i++)
            {
                emptyStr.Append(" ");
            }

            return emptyStr.ToString();
        }
    }
}
