using System;

namespace VariavelOpcional {
    class Program {
        static void Main(string[] args) {
            Nullable<double> x = null;

            double? y = null; // forma mais fácil de indicar que o y é nulo
            double? z = 10.0;

            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault()); // essa operacao retorna o valor que tem ou 
            // o nulo que no caso do double é 0
            Console.WriteLine(y.HasValue); // indica se tem algum valor declarado nessa variável
            // indicado por true ou false
            Console.WriteLine(z.HasValue);

            if (y.HasValue) {

                Console.WriteLine(y.Value); // é como se pegasse o valor diretamente do y,
                                            //caso coloque sem o if vai dar um erro pois não se pode fazer essa operacao com uma
                                            //variavel do tipo null
            } else {
                Console.WriteLine("X is null");

            }
            if (z.HasValue) {

                Console.WriteLine(z.Value);

            } else {
                Console.WriteLine("Y is null");

            }


}
    }
}
