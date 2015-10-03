using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimentionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] arr2D0 = new int[4, 6]
           {
                {1,2,3,4,5,6},
                {1,2,3000,4,5,6},
                {1,2,3,4,5,6},
                {1,2,3,4,5,6}
           };

            //Print(Sum2DX(arr2D0));
            //Print(Sum2DY(arr2D0));
            //Console.WriteLine("Sum2DX Result: " + "\n" + SumArray(Sum2DX(arr2D0)));
            //Console.WriteLine("Sum2DY Result: " + "\n" + SumArray(Sum2DY(arr2D0)));

            Print2D(arr2D0, FindLongestElement(arr2D0));

        }

        static int FindLongestElement(int[,] arr)
        {
            int y = arr.GetLength(0);
            int x = arr.GetLength(1);
            int k = 0;
            int[] res = new int[x * y];
            string resStr = "";
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    res[k] += arr[i, j];
                    k++;
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i].ToString().Length > resStr.Length)
                {
                    resStr = res[i].ToString();
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
                for (int j = 0; j < y; j++)
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
                for (int j = 0; j < x; j++)
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

            int[] resX = new int[y];
            int[] resY = new int[x];

            char separator = '|';

            PrintFrame(cellSpacing, x);

            for (int i = 0; i < y; i++)
            {

                for (int j = 0; j < x; j++)
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

                }
                Console.Write(separator);
                resX = Sum2DX(arr);
                Console.Write(" " + resX[i]);
                Console.WriteLine();
            }

            PrintFrame(cellSpacing, x);

            resY = Sum2DY(arr);
            for (int i = 0; i < resY.Length; i++)
            {
                Console.Write(resY[i] + MakeEmptyString(cellSpacing));
            }
            Console.WriteLine();


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

        static string MakeEmptyString(int cellSpacing)
        {

            StringBuilder emptyStr = new StringBuilder();

            for (int i = 0; i < cellSpacing - 1; i++)
            {
                emptyStr.Append(" ");
                //Console.WriteLine(emptyStr);
            }

            return emptyStr.ToString();
        }




    }
}
