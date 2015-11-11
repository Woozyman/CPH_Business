using System;

namespace CollectionFun
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestArrayEnumerator();
        }

        private static void TestArrayEnumerator()
        {
            var myEnum = new ArrayEnumerable<string>(5);
            myEnum.Set(0, "Zero");
            myEnum.Set(1, "One");
            myEnum.Set(2, "Two");
            myEnum.Set(3, "Three");
            myEnum.Set(4, "Four");

            foreach (var s in myEnum)
            {
                Console.WriteLine(s);
            }
        }

        private static void TestEvens()
        {
            var myEvens = new Evens(4, 42);

            /*
            {
                IEnumerator<int> en = myEvens.GetEnumerator();
                while (en.MoveNext())
                {
                    int item = en.Current;
                    Console.WriteLine(item);
                }
                en.Dispose();
            }
            */
            foreach (var item in myEvens)
            {
                Console.WriteLine(item);
            }
        }
    }
}