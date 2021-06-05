using System;

namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Digite o código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            int quant = int.Parse(Console.ReadLine());
            double total = 0.0;

            if (codigo == 1) {

                total = 4.0 * quant;

                Console.WriteLine($"Total: {total}");

            }else if(codigo == 2) {

                total = 4.5 * quant;

                Console.WriteLine($"Total: {total}");

            }else if (codigo == 3) {
                total = 5.0 * quant;

                Console.WriteLine($"Total: {total}");

            }else if (codigo == 4) {

                total = 2.0 * quant;

                Console.WriteLine($"Total: {total}");

            }
            else if(codigo == 5){
                total = 1.5 * quant;

                Console.WriteLine($"Total: {total}");
            }
            else {
                
            }

            
            }
        }
    }

