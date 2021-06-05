using System;
using System.Collections.Generic;

namespace Lista2 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");// adiciona elementos a lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");// por padrão adiciona ao final da lista

            list.Insert(2, "Marco"); // inseri na posição desejada

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // mostrar tamanho da lista

            string s1 = list.Find(x => x[0] == 'A');// expressão lambida: função anonima 
            // o objeto x do tipo string tal que  x[0] == primeiro caractere seja 'A'
            Console.WriteLine("Firts 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); //expressão retorna a ultima expressão da lista  a depender do parametro
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Posicion 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First Last 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }


            list.RemoveAt(3); // remove a partir da posicao
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            /* list.RemoveRange(2,2); // remove a partir da posicao, a partir da posição dois eu quero remover duas posições
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            } */
            list.Remove("Alex"); // se não encontar o que deseja, ele não faz nada

            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // espera um predicado
            Console.WriteLine("------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }

        /* static bool Test(string s) {
             return s[0] == 'A';*/
    }

}

