using System;
using projekt1.Model;
using projekt1.Controller;
namespace projekt1.View {
    static class Shape {
        public static void CalcR() {
            double width = TypeChecker.WriteAndReadDoubleLine("Ange bredden i cm: ");
            double height = TypeChecker.WriteAndReadDoubleLine("Ange höjden i cm: ");
            Model.Shape rectangle = new Model.Rectangle(width, height);
            Console.WriteLine(rectangle);
            Model.Json.Save(rectangle, "View/json/rectangle.json");
        }
        public static void CalcT() {
            double b = TypeChecker.WriteAndReadDoubleLine("Ange basen i cm: ");
            double h = TypeChecker.WriteAndReadDoubleLine("Ange höjden i cm: ");
            Model.Shape triangle = new Model.Triangle(b, h);
            Console.WriteLine(triangle);
            Model.Json.Save(triangle, "View/json/triangle.json");
        }

        public static void CalcC() {
            double r = TypeChecker.WriteAndReadDoubleLine("Ange radien i cm: ");
            Model.Shape circle = new Model.Circle(r);
            Console.WriteLine(circle);
            Model.Json.Save(circle, "View/json/circle.json");
        }

        public static void CalcCube() {
            double length = TypeChecker.WriteAndReadDoubleLine("Ange längden i cm: ");
            Model.Shape cube = new Model.Cube(length);
            Console.WriteLine(cube);
            Model.Json.Save(cube, "View/json/cube.json");
        }
        public static void CalcPyramid() {
            double bWidth = TypeChecker.WriteAndReadDoubleLine("Ange basens bredd i cm: ");
            double bLenght = TypeChecker.WriteAndReadDoubleLine("Ange basens längd i cm: ");
            double height = TypeChecker.WriteAndReadDoubleLine("Ange höjden i cm: ");
            Model.Shape pyramid = new Model.Pyramid(bWidth, bLenght, height);
            Console.WriteLine(pyramid);
            Model.Json.Save(pyramid, "View/json/pyramid.json");
        }
        public static void CalcSphere() {
            double r = TypeChecker.WriteAndReadDoubleLine("Ange radien i cm: ");
            Model.Shape sphere = new Model.Sphere(r);
            Console.WriteLine(sphere);
            Model.Json.Save(sphere, "View/json/sphere.json");
        }
    }
}