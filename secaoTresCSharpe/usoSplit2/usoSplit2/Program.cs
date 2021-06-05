using System;
using System.Globalization;

namespace usoSplit2
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            string[] vector = f.Split(' ');
            string nome = vector[0];
            char sexo = char.Parse(vector[1]);
            int idade = int.Parse(vector[2]);
            double altura = double.Parse(vector[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou :" + nome + " " +  sexo + " " + idade + " " + altura.ToString( "F2",CultureInfo.InvariantCulture));
        }
    }
}
