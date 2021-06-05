using System;

namespace FuncoesString {
    class Program {
        static void Main(string[] args) {
            string original = " abc DEFG bc hIj ";

            string s1 = original.ToUpper(); // transforma todo texto em maiúsculo 

            string s2 = original.ToLower(); // transforma em minusculo
            
            string s3 = original.Trim(); // apaga espaços em branco

            int n = original.IndexOf("bc"); // busca na variável ocorrência do que está entre aspas duplas
            
            int n2 = original.LastIndexOf("bc"); // busca na variável última ocorrência do que está entre aspas duplas

            string s4 = original.Substring(3); // recortar string da posicao escolhida em diante

            string s5 = original.Substring(3, 5); // recortar string da posicao escolhida com a quantidade de caracteres após a virgula

            string s6 = original.Replace("a","x"); // tem algumas sobrecargas pode substituir o caractere ou o string
            
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original); // testa se o contéudo da string é vazio ou nulo
            bool b2 = string.IsNullOrWhiteSpace(original); // testa se a variável é vazia ou um monte de espaços em branco


            Console.WriteLine("Original: "+"-"+ original+"-");
            Console.WriteLine("ToUpper: "+ "-" + s1 + "-");
            Console.WriteLine("ToUpper: " + "-" + s2 + "-");
            Console.WriteLine("ToUpper: " + "-" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): "+ n);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring: "+s4 + "-");
            Console.WriteLine("Substring: " + s5 + "-");
            Console.WriteLine("Replace('a','x'): "+ "-" + s6 + "-");
            Console.WriteLine("Replace('a','x'): " + "-" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: "+b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
