using System;
namespace projekt1.Model {
    class Menu {
        //menuItems2[x,0] = val 
        //menuItems2[x,1] = methodName
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

        public void InvokeMethod(Action Method) {
            Method();
        }

        public void PrintLine() => Console.WriteLine(new string('-', Console.WindowWidth));
    }
}