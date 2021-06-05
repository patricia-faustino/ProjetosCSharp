using System;
using System.Globalization;

namespace RevisaoVetorC {
    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Class1[] vect = new Class1[n];

            for(int i=0; i < n; i++) {

                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Class1(name, price);
            }

            double sum = 0.0;
            for(int i =0; i< n; i++) {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("Média dos valores dos produtos: "+avg.ToString("F2",CultureInfo.InvariantCulture));

            

        }
    }
}
