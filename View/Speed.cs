using System;
using projekt1.Controller;
namespace projekt1.View {
    static class Speed {
        public static void CalcSpeed() {
            Console.WriteLine($"Hastighet: {Model.Speed.CalcSpeed(TypeChecker.WriteAndReadDoubleLine("Ange sträckan i km: "), TypeChecker.WriteAndReadDoubleLine("Ange tiden i minuter: "))} km/h");
        }
        public static void CalcTime() {
            Console.WriteLine($"Tid: {Model.Speed.CalcTime(TypeChecker.WriteAndReadDoubleLine("Ange sträckan i km: "), TypeChecker.WriteAndReadDoubleLine("Ange hastigheten (km/h): "))} minuter");
        }
        public static void CalcDistance() {
            Console.WriteLine($"Sträcka: {Model.Speed.CalcDistance(TypeChecker.WriteAndReadDoubleLine("Ange Hastigheten (km/h): "), TypeChecker.WriteAndReadDoubleLine("Ange tiden i minuter: "))} km");
        }
    }
}