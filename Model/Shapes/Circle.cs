using System;
namespace projekt1.Model {
    class Circle : Shape {
        public double R { get; set; }

        public Circle(double r) => (R) = (r);
        public override double CalcArea() {
            return Math.PI * Math.Pow(R, 2);
        }

        public override string ToString() {
            return $"Cirkelns area är: {Math.Round(CalcArea(), 3)} cm.";
        }
    }
}