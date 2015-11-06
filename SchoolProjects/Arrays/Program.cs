using System;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {11,23,45,678,54,32};

            
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Sum of all elements of array: " + Sum(arr));
            Console.WriteLine(MakeString(arr));
            Test(arr);
            Console.WriteLine(MakeString(arr));
            MakeEven(arr);
            Console.WriteLine(MakeString(arr));



        }

        static int Sum(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res = res + arr[i];
            }

            return res;
        }

        static string MakeString(int[] arr)
        {
            StringBuilder res = new StringBuilder();
            res.Append('{');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    res.Append(',');
                }
                res.Append(arr[i]);
            }
            res.Append('}');
            return res.ToString();
        }

        static void Double(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += arr[i] * 2;
            }
        }

        static int Double(int num)
        {
            return num * 2;
        }

        static void Test(int[] arr)
        {
            int[] tmp = { 1, 2, 3 };
            arr = tmp;

            Console.Write('{');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            
            Console.WriteLine('}');
        }

        static int SumEven(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0)
                {
                    res += arr[i];
                }
            }

            return res;
        }

        static void MakeEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[i] += 1;
                }
            }
        }
    }
}
