using System;
using System.Globalization;

namespace exclass1 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = "+r.Area());
            Console.WriteLine("PERÍMETRO = " + r.Perimetro());
            Console.WriteLine("DIAGONAL = " + r.Diagonal());
        }
    }
}
