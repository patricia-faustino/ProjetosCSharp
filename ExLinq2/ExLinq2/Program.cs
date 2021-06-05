using System;
using System.Collections.Generic;
using ExLinq2.Entities;
using System.Linq;


namespace ExLinq2
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collections)
        {
            Console.WriteLine(message);
            foreach (T obj in collections)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name = "Tv", Price = 1700.0, Category = c3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product(){Id = 6, Name = "Tablet", Price = 700.00, Category = c2},
                new Product(){Id = 7, Name = "Camera", Price = 700.00, Category = c3},
                new Product(){Id = 8, Name = "Printer", Price = 350.00, Category = c3},
                new Product(){Id = 9, Name = "MacBook", Price = 1800.00, Category = c2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3},
                new Product(){Id = 11, Name = "Level", Price = 70.00, Category = c1}
            };



            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 =
               //todo objeto p na fonte de dados products
               from p in products
               where p.Category.Tier == 1 && p.Price < 900.00
               //projecao
               select p;

             Print("Tier 1 and Price < 900: ", r1);

            // var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;

            Print("Names of products from Tools", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    //deve ser colocado o apelido para nao gerar ambiguidar e dar erro
                    CategoryName = p.Category.Name

                };
            Print("Names started with 'C' and anonymous object", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                //na sintaxe sql coloca-se na ordem inversa do que se deseja
                orderby p.Name
                orderby p.Price
                select p;
            Print("Tier 1 order By Price the By Name", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 Order By Price then By Name Skip 2 Take 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First Or Default Test1: "+ r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("First Or Default Test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default Test1: "+ r8);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: "+r10);
            Console.WriteLine();

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: "+ r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.00).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.00,(x, y) => x + y);
            Console.WriteLine("Category 1 Agregate Sum: "+ r15);

            Console.WriteLine();

            //Agrupamento
            var r16 = products.GroupBy(p => p.Category);
            // foreach(IGrouping<Chave, Colecao> group in r16)
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category "+group.Key.Name);
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();

            }
        }
    }
}
