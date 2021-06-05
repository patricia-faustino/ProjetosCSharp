using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using ExResolvidoLinq.Entities;

namespace ExResolvidoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            //converter lista de produtos  para lista double
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.00).Average();
            Console.WriteLine("Average Price: " + avg.ToString("F2",CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
