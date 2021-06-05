using System;
using System.Collections.Generic;

namespace ExHashIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Alex");
            Console.WriteLine(set.Contains("Maria"));
        }
    }
}
