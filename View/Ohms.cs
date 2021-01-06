using System;
using projekt1.Controller;
namespace projekt1.View {
    static class Ohms {
        public static void CalcR() {
            Console.WriteLine($"R: {Model.Ohms.CalcR(TypeChecker.WriteAndReadDoubleLine("Ange V: "), TypeChecker.WriteAndReadDoubleLine("Ange I: "))}");
        }
        public static void CalcV() {
            Console.WriteLine($"V: {Model.Ohms.CalcV(TypeChecker.WriteAndReadDoubleLine("Ange R: "), TypeChecker.WriteAndReadDoubleLine("Ange I: "))}");
        }
        public static void CalcI() {
            Console.WriteLine($"I: {Model.Ohms.CalcI(TypeChecker.WriteAndReadDoubleLine("Ange V: "), TypeChecker.WriteAndReadDoubleLine("Ange R: "))}");
        }
    }
}