using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace correcaoexercico {
    class ContaBancaria {
        public int Numero  { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero,string titular) {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular,  double depositoinicial):this(numero,titular) {
            Deposito(depositoinicial);

        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= (quantia + 5.00);
        }
        public override string ToString() {
            return "Conta "+ Numero+ ", Titular: "+
                Titular+", Saldo: $ "+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
        
    }
}
