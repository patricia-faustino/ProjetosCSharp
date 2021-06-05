using System;


namespace RepetirEFMatriz {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de linhas e colunas, sucessivamente: ");
            string[] line = Console.ReadLine().Split(' '); //criacao de vetor line para ser digitado linha por linha e coluna por coluna

            int m = int.Parse(line[0]); // conversao de string para int, pecorrendo a primeira posicao do vetor sendo separado por espaco

            int n = int.Parse(line[1]); // conversao de string para int, pecorrendo a segunda posicao do vetor, sendo distinto cada elemento
            //por espaço

            int[,] mat = new int[m, n]; // instanciacao da matriz, atribuindo m a linhas e n a colunas 

            for (int i=0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' '); // criaçaco do vetor

                for(int j=0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]); //chamada da matriz mat com linhas i e colunas j
                    

                }

            }
            Console.WriteLine("Digite um valor da matriz: ");
            int x = int.Parse(Console.ReadLine());
            for(int i=0; i < m; i++) {

                for(int j= 0; j < n; j++) {
                    if(mat[i, j] == x) {
                        Console.WriteLine($"Position: {i}, {j}");
                        if (j > 0) {
                            Console.WriteLine($"Left: {mat[i, j-1]}");
                        } if (j < n-1) {
                            Console.WriteLine($"Right: {mat[i, j+1]}");
                        } if(i < m - 1) {
                            Console.WriteLine($"Down: {mat[i+1, j]}");
                        } if(i > 0) {
                            Console.WriteLine($"Up: {mat[i-1, j]}");

                        }

                    }
                     


                }
            }

        }
    }
}
