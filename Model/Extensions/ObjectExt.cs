using System;
using System.Collections.Generic;
namespace projekt1.ObjectExt {
    public static class ObjectExt {
        public static void ConsoleWriteToString(this object obj) {
            Console.WriteLine(obj.ToString());
        }
    }
}