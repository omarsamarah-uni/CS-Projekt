using System;
namespace projekt1.Model {
    [Serializable]
    class Rectangle : Shape {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle() { }
        public Rectangle(double width, double height) => (Width, Height) = (width, height);
        public override double CalcArea() {
            return Width * Height;
        }

        public override string ToString() {
            return $"Rektangelns area är: {Math.Round(CalcArea(), 3)} cm.";
        }

        public void Write() {
            Console.WriteLine(ToString());
        }

    }
}