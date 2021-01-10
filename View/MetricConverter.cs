using System;
namespace projekt1.View {
    static class MetricConverter {
        public static void ConvertFromTum() {
            Console.WriteLine($"{Model.MetricConverter.ConvertFromTum(Model.TypeChecker.WriteAndReadDoubleLine("Ange mått i tum: "))} ");
        }
        public static void ConvertFromCm() {
            Console.WriteLine($"{Model.MetricConverter.ConvertFromCm(Model.TypeChecker.WriteAndReadDoubleLine("Ange mått i cm:"))} ");
        }

        public static void ConvertFromFoot() {
            Console.WriteLine($"{Model.MetricConverter.ConvertFromFoot(Model.TypeChecker.WriteAndReadDoubleLine("Ange mått i fot: "))} ");
        }

        public static void ConvertFromYard() {
            Console.WriteLine($"{Model.MetricConverter.ConvertFromYard(Model.TypeChecker.WriteAndReadDoubleLine("Ange mått i yard: "))} ");
        }

        public static void ConvertFromMeter() {
            Console.WriteLine($"{Model.MetricConverter.ConvertFromMeter(Model.TypeChecker.WriteAndReadDoubleLine("Ange mått i meter: "))} ");
        }

    }
}