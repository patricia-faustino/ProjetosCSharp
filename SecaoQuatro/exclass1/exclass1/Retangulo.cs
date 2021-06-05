using System;
using System.Globalization;

namespace exclass1 {
    class Retangulo {
        public double Altura;
        public double Largura;
        
        public double Area() {
            return Altura * Largura;
        }
        
        public double Perimetro() {
            return ((2 * Altura) + (2 * Largura));
        }
        public double Diagonal() {
            return Math.Sqrt( Math.Pow(Altura,2) +Math.Pow(Largura,2));
        }

        
        }
    }

