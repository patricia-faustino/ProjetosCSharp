using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator {
    class Calc {
        public static int Sum(params int[] numbers) { // params: não precisa instanciar
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
