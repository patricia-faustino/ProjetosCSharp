using System;
using System.Globalization;

namespace Course1 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            r.Area();
            r.Perimetro();
            r.Diagonal();
          
            Console.WriteLine("AREA = " + r.Area());
            Console.WriteLine("PERIMETRO= " + r.Perimetro());
            Console.WriteLine("DIAGONAL= " + r.Diagonal());
        }
    }
}
