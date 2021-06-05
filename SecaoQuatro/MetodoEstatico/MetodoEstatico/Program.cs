using System;
using System.Globalization;
namespace MetodoEstatico {
    class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
           

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circunferência = Circunferência(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circunferência.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");

          
            }
        static double Circunferência(double r) {
            return 2.0 * Pi * r;
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
    }

