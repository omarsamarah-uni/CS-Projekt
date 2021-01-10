using System;
namespace projekt1.View {
    static class Ohms {
        public static void CalcR() {
            Console.WriteLine($"R: {Model.Ohms.CalcR(Model.TypeChecker.WriteAndReadDoubleLine("Ange V: "), Model.TypeChecker.WriteAndReadDoubleLine("Ange I: "))}");
        }
        public static void CalcV() {
            Console.WriteLine($"V: {Model.Ohms.CalcV(Model.TypeChecker.WriteAndReadDoubleLine("Ange R: "), Model.TypeChecker.WriteAndReadDoubleLine("Ange I: "))}");
        }
        public static void CalcI() {
            Console.WriteLine($"I: {Model.Ohms.CalcI(Model.TypeChecker.WriteAndReadDoubleLine("Ange V: "), Model.TypeChecker.WriteAndReadDoubleLine("Ange R: "))}");
        }
    }
}