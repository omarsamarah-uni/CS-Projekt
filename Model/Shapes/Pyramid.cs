using System;
namespace projekt1.Model {
    class Pyramid : Shape {
        public double BWidth { get; set; }
        public double BLenght { get; set; }
        public double Height { get; set; }

        public Pyramid(double bWidth, double bLenght, double height)
            => (BWidth, BLenght, Height) = (bWidth, bLenght, height);
        public override double CalcVolume() {
            return BWidth * BLenght * Height / 3;
        }

        public override string ToString() {
            return $"Pyramidens volym är: {Math.Round(CalcVolume(), 3)} cm.";
        }
    }
}