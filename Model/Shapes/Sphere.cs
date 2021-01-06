using System;
namespace projekt1.Model {
    class Sphere : Shape {
        public double R { get; set; }
        public Sphere(double r) => (R) = (r);
        public override double CalcVolume() {
            return 4 * Math.PI * Math.Pow(R, 3) / 3;
        }
        public override string ToString() {
            return $"Sfärens volym är: {Math.Round(CalcVolume(), 3)} cm.";
        }
    }
}