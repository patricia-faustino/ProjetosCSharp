using System;
using System.Globalization;

namespace DateT {
    class Program {
        static void Main(string[] args) {

            // instancia chamando o instante de acordo com o sistema

            DateTime d2 = new DateTime(2018, 11, 25); // instacia desse dia no horário da meia noite

            DateTime d3 = new DateTime(2018, 11, 25, 4, 20, 45); // (ano, mes, data, hora, minuto, segundo)

            DateTime d4 = new DateTime(2018, 11, 25, 4, 20, 45, 500);

            //Builders

            DateTime d1 = DateTime.Now;
            DateTime d5 = DateTime.Today; // imprime dia de hoje no horario das zero horas
            DateTime d6 = DateTime.UtcNow; //horário de agora tendo como base Genuiti, 3h de diferenca

            //Transformaçao String

            DateTime d7 = DateTime.Parse("2015-08-15"); // formato padrao de  banco de dados
            DateTime d8 = DateTime.Parse("2015-08-15 13:08:55");
            DateTime d9 = DateTime.Parse("15/08/2015");
            DateTime d10 = DateTime.Parse("15/08/2015 13:08:55");

            DateTime d11 = DateTime.ParseExact("2015-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);// informar a data da forma exata 
            //que se deseja("data desjada","formato desejado", Formato padrao)
            DateTime d12= DateTime.ParseExact("15/08/2015 13:08:55","dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);



            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4); // não imprime os milisegundos, precisa de uma formataçao
            Console.WriteLine(d1.Ticks); // devolve a quantidade de ticks de 1 de janeiro dessa era até o momento atula
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);





        }
    }
}
