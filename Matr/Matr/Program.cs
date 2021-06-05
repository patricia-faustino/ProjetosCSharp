using System;

namespace Matr {
    class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);// ELEMENTOS DA MATRIZ
            Console.WriteLine(mat.Rank); // primeira dimensão da matriz, quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); // dimensão 0 da matriz tem tamanho dois
            Console.WriteLine(mat.GetLength(1)); // quantidade de colunas da matriz
        }
    }
}
