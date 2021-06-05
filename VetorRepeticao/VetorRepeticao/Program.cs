using System;
using System.Globalization;

namespace VetorRepeticao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o numero de pessoas que serão inseridas as alturas(N): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            double[] vect = new double[n];
            for(int i= 0; i < n; i++) {
                Console.WriteLine("Digite a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

            }
           
            
            for(int i=0; i< n; i++) {

                sum += vect[i];

            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = "+avg);
        }
    }
}
