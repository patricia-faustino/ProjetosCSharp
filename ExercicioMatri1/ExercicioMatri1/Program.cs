using System;

namespace ExercicioMatri1 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0;i < n;i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) { // inicialmente pega a primeira linha e vai posicionando cada intem da coluna
                 // por exemplo ele pega o item na posição[0,0], logo após incrementa e volta para o item[0,1], logo após para o item [0,2]
                 // o for volta para condição que vai dar a parada e vai para o for com o i
                    mat[i, j] = int.Parse(values[j]);
                }


            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i]+ " ");
            }
            int count = 0;
            for(int i=0; i < n; i++) {

                for(int j=0; j < n; j++) {

                    if(mat[i , j] < 0) {

                        count++;
                    }

                }
            }
            Console.WriteLine("Negative numbers = "+count);
        }
    }
}
