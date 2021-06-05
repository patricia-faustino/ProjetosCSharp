using System;
using System.Globalization;

namespace Course4 {
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get;  set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;

        }
        public ContaBancaria(int numero, string titular, double saldo):this(numero, titular) {
            
            Saldo = saldo;
        }
        
        public void Deposito(double entsai) {
            Saldo += entsai;
        }
        public void Saque(double entsai) {
            Saldo -= entsai + 5.00;
        }
        public override string ToString() {
            return "Conta "+ Numero+ ", Titular: "+Titular+
                ", Saldo: $ "+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
