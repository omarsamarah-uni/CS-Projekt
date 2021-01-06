using System;
using System.Collections.Generic;
namespace projekt1.ListExt {
    public static class ListExt {
        public static int NoNullCount<T>(this List<T> list) {
            if (list == null) return 0;
            else return list.Count;
        }
    }
}