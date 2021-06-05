using System;

namespace DateTFormatacao {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2001, 08, 15, 12, 55, 42, 500);
            Console.WriteLine(d1.ToLongDateString());

            string s2 = d1.ToLongDateString();
            Console.WriteLine(s2);

            string s3 = d1.ToLongTimeString();
            Console.WriteLine(s3);

            string s4 = d1.ToShortDateString();
            Console.WriteLine(s4); // imprime a hora resumida, no padrao local

            string s5 = d1.ToShortTimeString();
            Console.WriteLine(s5); // imprime somente hora e segundo

            string s6 = d1.ToString();
            Console.WriteLine(s6); // imprime no padrao ja conhecido

            string s7 = d1.ToString("yyyy-MM-dd HH-mm-ss");
            Console.WriteLine(s7); // o ToString tem varias sobrecargas que podem ser utilizadas atraves de mascaras

            string s8 = d1.ToString("yyyy-MM-dd HH-mm-ss.fff");
            Console.WriteLine(s8);
        }
    }
}
