using System;

namespace usoDoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] vector = s.Split(' ');
            string p1 = vector[0];
            string p2 = vector[1];
            string p3 = vector[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

        }
    }
}
