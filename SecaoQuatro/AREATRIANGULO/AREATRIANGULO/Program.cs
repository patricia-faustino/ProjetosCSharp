using System;
using System.Globalization;

namespace AREATRIANGULO {
    class Program {
        static void Main(string[] args) {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = "+ areaX.ToString("F4",CultureInfo.InvariantCulture));

            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY) {

                Console.WriteLine(" Maior área: Y ");

            }else if(areaY > areaX) {

                Console.WriteLine(" Maior área: Y ");

            }
        }
    }
}
