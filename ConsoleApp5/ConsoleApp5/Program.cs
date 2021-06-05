using System;
using System.Globalization;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
           
                int quantidade = int.Parse(Console.ReadLine());

                double[] vect = new double[quantidade]; // criando o vetor na memória

                for (int i = 0; i < quantidade; i++) {
                    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double sum = 0.0;

                for (int i = 0; i < quantidade; i++) {
                    sum += vect[i];
                }

                double avg = sum / quantidade;

                Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }

