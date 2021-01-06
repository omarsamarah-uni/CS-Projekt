using System;
namespace projekt1.Model {
    static class Speed {
        public static double CalcSpeed(double distance, double time) {
            return distance / time;
        }
        public static double CalcTime(double dis, double speed) {
            return dis / speed;
        }
        public static double CalcDistance(double speed, double time) {
            return speed * time;
        }

    }
}