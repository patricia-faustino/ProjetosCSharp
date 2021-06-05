using System;
using System.IO;

namespace FileandFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAMINHO DO ARQUIVO DE ORIGEM

            string sourcePath = @"C:\Users\i-ire\Desktop\Nova pasta\file1.txt";
            //CAMINHO DO ARQUIVO DE DESTINO

            string targetPath = @"C:\Users\i-ire\Desktop\Nova pasta\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //Guardar conteudo no vetor de strings
                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e);


            }
        }
    }
}

