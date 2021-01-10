using System;
namespace projekt1.View {
    static class Speed {
        public static void CalcSpeed() {
            Console.WriteLine($"Hastighet: {Model.Speed.CalcSpeed(Model.TypeChecker.WriteAndReadDoubleLine("Ange sträckan i km: "), Model.TypeChecker.WriteAndReadDoubleLine("Ange tiden i minuter: "))} km/h");
        }
        public static void CalcTime() {
            Console.WriteLine($"Tid: {Model.Speed.CalcTime(Model.TypeChecker.WriteAndReadDoubleLine("Ange sträckan i km: "), Model.TypeChecker.WriteAndReadDoubleLine("Ange hastigheten (km/h): "))} minuter");
        }
        public static void CalcDistance() {
            Console.WriteLine($"Sträcka: {Model.Speed.CalcDistance(Model.TypeChecker.WriteAndReadDoubleLine("Ange Hastigheten (km/h): "), Model.TypeChecker.WriteAndReadDoubleLine("Ange tiden i minuter: "))} km");
        }
    }
}