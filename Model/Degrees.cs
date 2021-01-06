using System;
using System.Reflection;
namespace projekt1.Model {
    static class Degrees {
        public static double ConvertFromF(string unit, double input) {
            double res = 0.0;
            if (unit.Equals("c")) {
                res = (input - 32.00) / 1.8;
            }
            else if (unit.Equals("k")) {
                res = 5.0 / 9.0 * (input + 459.67);
            }
            return res;
        }

        public static double ConvertFromC(string unit, double input) {
            double res = 0.0;
            if (unit.Equals("f")) {
                res = (input * 9.0 / 5.0) + 32.0;
            }
            else if (unit.Equals("k")) {
                res = input + 273.15;
            }
            return res;
        }

        public static double ConvertFromK(string unit, double input) {
            double res = 0.0;
            if (unit.Equals("f")) {
                res = (input - 273.15) * 9 / 5 + 32;
            }
            else if (unit.Equals("c")) {
                res = input - 273.15;
            }
            return res;
        }

    }
}