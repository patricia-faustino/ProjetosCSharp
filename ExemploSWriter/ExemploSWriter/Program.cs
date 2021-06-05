using System;
using System.IO;

namespace ExemploSWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\i-ire\Desktop\Nova pasta\file1.txt";
            string targePath = @"C:\Users\i-ire\Desktop\Nova pasta\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using(StreamWriter sw= File.AppendText(targePath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
