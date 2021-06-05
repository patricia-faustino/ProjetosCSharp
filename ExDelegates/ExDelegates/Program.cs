using System;

namespace ExDelegates
{
    //referencia para uma funcao que recebe dois numeros double e retorna um numero double

    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a,b);
          
        }
    }
}
