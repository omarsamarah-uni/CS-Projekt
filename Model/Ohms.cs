using System;
namespace projekt1.Model {
    static class Ohms {
        public static double CalcR(double v, double i) {
            return v / i;
        }
        public static double CalcV(double r, double i) {
            return r * i;
        }
        public static double CalcI(double v, double r) {
            return v / r;
        }
    }
}