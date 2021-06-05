using System;
using System.IO;

namespace ExemploUBlocking
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\i-ire\Desktop\Nova pasta\file1.txt";

            try { 
            //tudo vai ser instanciado e ao final do bloco será automaticamente fechado
           
                using (StreamReader sr= File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
