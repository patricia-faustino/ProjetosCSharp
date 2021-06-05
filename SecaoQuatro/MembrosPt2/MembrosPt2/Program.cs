using System;
using System.Globalization;

namespace MembrosPt2 {
    class Program {
        
        static void Main(string[] args) {
           

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculado.Circunferencia(raio);
            double volume = Calculado.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculado.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
