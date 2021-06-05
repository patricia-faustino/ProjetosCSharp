using System;

namespace ifelse {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a hora ");
            int hora = int.Parse(Console.ReadLine());




            if (hora < 12) {
                Console.WriteLine("Bom Dia!");

            }
            else if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

        }

}
    }

