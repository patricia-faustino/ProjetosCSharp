using System;
using System.Globalization;

namespace Recap2 {
    class Area {
        public double A;
        public double B;
        public double C;

        public AreTriangulo() {
            double p= p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
