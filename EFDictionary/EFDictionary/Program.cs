using System;
using System.IO;
using System.Collections.Generic;


namespace EFDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {

                        string[] register = sr.ReadLine().Split(',');
                        string candidatename = register[0];
                        int vote = int.Parse(register[1]);
                        if (dictionary.ContainsKey(candidatename))
                        {
                            dictionary[candidatename] += vote;
                        }
                        else
                        {
                            dictionary[candidatename] = vote;
                        }

                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
