using System;
using System.Reflection;
namespace projekt1.Controller {
    static class TypeChecker {
        public static int WriteAndReadIntLine(string msg) {
            Console.WriteLine(msg);
            int num;
            while (!int.TryParse(Console.ReadLine(), out num)) {
                Console.WriteLine("Endast siffror är tillåtna!!");
                Console.WriteLine(msg);
            }
            return num;
        }

        public static double WriteAndReadDoubleLine(string msg) {
            Console.WriteLine(msg);
            double num;
            while (!double.TryParse(Console.ReadLine(), out num)) {
                Console.WriteLine("Endast siffror är tillåtna!!");
                Console.WriteLine(msg);
            }
            return num;
        }
    }
}