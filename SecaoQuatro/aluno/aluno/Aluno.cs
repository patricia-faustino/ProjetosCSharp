using System;
using System.Collections.Generic;
using System.Text;

namespace aluno {
    class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {

            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado() {

            if(NotaFinal() >= 60) {
                return true;

                 } else {
                return false;

            }
        }
        public double QuantoFalta() {
            return 60 - NotaFinal();
        }

        public override string ToString() {
            return "NOTA FINAL = "+ NotaFinal();
        }

    }
}
