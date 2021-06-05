using System;

namespace atividadeVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota1 = new double[20];
            double[] notas = new double[20];
            double mediaAluno = 0.0;
            double mediaTurma = 0.0;

            for(int i = 0; i < 20; i++)
            {

                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Informe a nota da atidade {j + 1}, aluno{i + 1}: ");
                    nota1[j] = double.Parse(Console.ReadLine());
                    notas[i] = notas[i] + nota1[j];
                    if(j == 3)
                    {
                        mediaAluno = notas[i] / 4;
                        Console.WriteLine(mediaAluno);
                    }
                }

            }


        }
    }
}
