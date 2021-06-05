using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exercicio2clas {
    class Funcionário {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public double SalarioLiquido() {

            return SalarioBruto - Imposto;

        }

        public override string ToString() {

            return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);

        }

    }
}
