using System;
namespace projekt1.Model {
    public static class MetricConverter {
        public static string ConvertFromTum(double tum) {
            double cm = tum / 0.39370;
            double foot = tum * 0.083333;
            double yard = tum * 0.027778;
            double m = tum / 39.370;
            return $"{tum}tum är {Math.Round(cm, 4)}cm, {Math.Round(foot, 4)}fot, {Math.Round(yard, 4)}yard och {Math.Round(m, 4)}m.";
        }

        public static string ConvertFromCm(double cm) {
            double tum = cm * 0.39370;
            double foot = cm * 0.032808;
            double yard = cm * 0.0109361;
            double m = cm / 100.00;
            return $"{cm}cm är {Math.Round(tum, 4)}tm, {Math.Round(foot, 4)}fot, {Math.Round(yard, 4)}yard och {Math.Round(m, 4)}m.";
        }

        public static string ConvertFromFoot(double foot) {
            double cm = foot / 0.032808;
            double tum = foot * 12.000;
            double yard = foot * 0.33333;
            double m = foot / 3.2808;
            return $"{foot}fot är {Math.Round(cm, 4)}cm, {Math.Round(tum, 4)}tum, {Math.Round(yard, 4)}yard och {Math.Round(m, 4)}m.";
        }

        public static string ConvertFromYard(double yard) {
            double cm = yard / 0.010936;
            double tum = yard * 36.000;
            double foot = yard * 3.0000;
            double m = yard / 1.0936;
            return $"{yard}yard är {Math.Round(cm, 4)}cm, {Math.Round(tum, 4)}tum, {Math.Round(foot, 4)}fot och {Math.Round(m, 4)}m.";
        }
        public static string ConvertFromMeter(double m) {
            double cm = m / 0.010000;
            double tum = m * 39.370;
            double foot = m * 3.2808;
            double yard = m * 1.0936;
            return $"{m}m är {Math.Round(cm, 4)}cm, {Math.Round(tum, 4)}tum, {Math.Round(foot, 4)}fot och {Math.Round(yard, 4)}yard.";
        }
    }
}