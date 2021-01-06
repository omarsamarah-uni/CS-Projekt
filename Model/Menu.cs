using System;
using System.Reflection;
namespace projekt1.Model {
    class Menu {
        //menuItems2[0,0] = val 
        //menuItems2[0,1] = methodName
        //menuItems2[0,2] = param
        //menuItems2[0,3] = obj
        public void ShowMenu(object[,] menuItems) {
            while (true) {
                PrintLine();
                for (int i = 0; i < menuItems.GetLength(0); i++) {
                    Console.WriteLine($"{i + 1} - {(string)menuItems[i, 0]} ");
                }
                PrintLine();
                if (int.TryParse(Console.ReadLine(), out int choice)) {
                    if (choice <= menuItems.GetLength(0)) {
                        for (int i = 0; i < menuItems.GetLength(0); i++) {
                            if (choice == i + 1) InvokeMethod((Action)menuItems[i, 1]);
                        }
                    }
                    else Console.WriteLine("Ogilltigt värde!");
                }
                else Console.WriteLine("Fleaktig datatyp!");
                PrintLine();
                Console.WriteLine("Tryck på en knapp för att via menyn igen");
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        /*  public void invokeMethod(Object obj, string methodName, object[] param) {
             var res = obj.GetType().GetMethod(methodName).Invoke(obj, param);
             Console.WriteLine(res);
         } */

        /* static T InvokeMethod<T>(Func<T> Method) {
            return Method();
        } */

        public void InvokeMethod(Action Method) {
            Method();
        }

        public void InvokeMethod(Action Method, object[] param) {
            Method();
            Method.DynamicInvoke(param);
        }

        public void PrintLine() => Console.WriteLine(new string('-', Console.WindowWidth));
    }
}