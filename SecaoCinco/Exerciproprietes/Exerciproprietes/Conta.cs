using System;
using System.Globalization;


namespace Exerciproprietes {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        private double Saldo { get; private set; }
        



        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;

        }

        public Conta(int numero, string titular,double saldo)  {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;

        }
        public void Saque (double quantia) {
            Saldo += quantia;
            

        }
        public void Deposito(double quantia) {
            Saldo -= (5.00+ quantia);


        }
        public override string ToString() {
            return "Conta " + Numero + ", Titular: " +
                Titular + ", Saldo: $ " + Saldo;


        }
    }
}
