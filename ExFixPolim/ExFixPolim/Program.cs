﻿using System;
using System.Globalization;
using System.Collections.Generic;
using ExFixPolim.Entities;

namespace ExFixPolim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i= 1; i<= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                
                if(ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }else if(ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UseProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
                

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product produ in list)
            {
                Console.WriteLine(produ.PriceTag());
            }
        }
    }
}
