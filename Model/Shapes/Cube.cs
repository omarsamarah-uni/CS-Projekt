using System;
namespace projekt1.Model {
    class Cube : Shape {
        public double Length { get; set; }

        public Cube(double length) => (Length) = (length);
        public override double CalcArea() {
            return Length * Length;
        }

        public override double CalcVolume() {
            return Math.Pow(Length, 3);
        }

        public override string ToString() {
            return $"Kubens area är: {Math.Round(CalcArea(), 3)} cm. Volymen är {Math.Round(CalcVolume(), 3)} cm.";
        }
    }
}