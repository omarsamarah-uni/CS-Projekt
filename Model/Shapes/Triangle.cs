using System;
namespace projekt1.Model {
    class Triangle : Shape {
        public double B { get; set; }
        public double H { get; set; }

        public Triangle(double b, double h) => (B, H) = (b, h);
        public override double CalcArea() {
            return B * H / 2.0;
        }

        public override string ToString() {
            return $"Arean på triangeln är: {Math.Round(CalcArea(), 3)} cm.";
        }
    }
}