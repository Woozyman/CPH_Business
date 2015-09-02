using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Write/Read Example");

            StreamWriter Writer = new StreamWriter("TextFile1.txt");
            Writer.WriteLine("This is my first attempt to write a file!");
            Writer.Close();

            StreamReader Reader = new StreamReader("TextFile1.txt");
            string OutputString = Reader.ReadLine();
            Reader.Close();
            Console.WriteLine(OutputString);
        }
    }
}
