using System;
using System.IO;
using System.Collections.Generic;
using ExItComparable.Entities;
namespace ExItComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //comparar itens do arquivo
            string path = @"C:\Users\i-ire\Documents\LINGUAGENS DE PROGRAMAÇÃO\C#\HardCode.txt";
            try{
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Emplooye> list = new List<Emplooye>();
                    while (!sr.EndOfStream)
                    {
                       list.Add(new Emplooye(sr.ReadLine()));
                    }
                    //ordenar lista
                    list.Sort();
                    foreach(Emplooye emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
