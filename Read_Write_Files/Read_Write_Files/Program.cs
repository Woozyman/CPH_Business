using System;
using System.IO;

namespace Read_Write_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Write/Read Example");
            Console.WriteLine();
            
            string inputStr;
            string File = "TextFile1.txt";
            StreamWriter writer = new StreamWriter(File);
            inputStr = Console.ReadLine();
            writer.WriteLine(inputStr);
            writer.Close();

            StreamReader reader = new StreamReader(File);
            string outputString = reader.ReadLine();
            reader.Close();
            Console.WriteLine("Reader output: " + outputString);
            
            //comment
        }
    }
}
