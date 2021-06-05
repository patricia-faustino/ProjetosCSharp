using System;
using System.Globalization;
namespace ex2 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];
            for(int i = 0; i < n; i ++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };

            }
            double som = 0.0;
            for(int i=0; i < n; i++) {
                som += vect[i].Price; // acessar caixa de preço
            }
            double avg = som/n;
            Console.WriteLine("PREÇO MÉDIO = "+ avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
