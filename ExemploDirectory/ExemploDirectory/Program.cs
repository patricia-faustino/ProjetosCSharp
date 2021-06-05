using System;
using System.IO;
using System.Collections.Generic;

namespace ExemploDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAMINHO BASE
            string path = @"C:\Users\i-ire\source\repos\temp";

            try
            {
                //LISTAR SUBPASTAS A PARTIR DA PASTA TEMP
                //IEnumerable:tipo genérico de coleção
                //*.*: QUALQUER NOME DE ARQUIVO, QUALQUER EXTENSÃO


                IEnumerable<string> folders= Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

   
