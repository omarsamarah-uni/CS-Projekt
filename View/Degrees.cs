using System;
using projekt1.Controller;
namespace projekt1.View {
    static class Degrees {
        public static void ConvertFromF() {
            double input = TypeChecker.WriteAndReadDoubleLine("Hur många grader i F°: ");

            Console.WriteLine($"C: {Math.Round(Model.Degrees.ConvertFromF("c", input), 3)}");
            Console.WriteLine($"K: {Math.Round(Model.Degrees.ConvertFromF("k", input), 3)}");
        }
        //Math.Round(Model.Degrees.ConvertFromK("f", input), 3)
        public static void ConvertFromC() {
            double input = TypeChecker.WriteAndReadDoubleLine("Hur många grader i C°: ");
            Console.WriteLine($"F: {Math.Round(Model.Degrees.ConvertFromC("f", input), 3)}");
            Console.WriteLine($"K: {Math.Round(Model.Degrees.ConvertFromC("k", input), 3)}");
        }

        public static void ConvertFromK() {
            double input = TypeChecker.WriteAndReadDoubleLine("Hur många grader i K°: ");
            Console.WriteLine($"F: {Math.Round(Model.Degrees.ConvertFromK("f", input), 3)}");
            Console.WriteLine($"C: {Math.Round(Model.Degrees.ConvertFromK("c", input), 3)}");
        }
    }
}