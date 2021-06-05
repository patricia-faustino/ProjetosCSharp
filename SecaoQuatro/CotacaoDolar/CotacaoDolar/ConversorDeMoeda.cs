namespace CotacaoDolar {
    class ConversorDeMoeda {
        public static double iof= 6.0;
        public static double conv (double d, double c) {
            double total = c * d;
            return total + total * iof/100 ;
        }
    }
}
