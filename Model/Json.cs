using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace projekt1.Model {
    static class Json {
        public static int MaxObjs = 2;
        public static void Save(object obj, string path) {
            List<object> objectList = new List<object>();
            var options = new JsonSerializerOptions {
                WriteIndented = true,
            };

            if (!File.Exists(path)) {
                StreamWriter sw = File.CreateText(path);
            }
            else {
                if (new FileInfo(path).Length > 0) {
                    try {
                        string jsString = File.ReadAllText(path);
                        objectList = JsonSerializer.Deserialize<List<object>>(jsString);
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            if (objectList.Count == MaxObjs) objectList.RemoveAt(0);
            objectList.Add(obj);

            string jsonString = JsonSerializer.Serialize(objectList, options);
            try {
                File.WriteAllText(path, jsonString);

            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static List<T> ReturnObjList<T>(string path) {
            if (File.Exists(path)) {
                if (new FileInfo(path).Length > 0) {
                    try {
                        string jsonString = File.ReadAllText(path);
                        return JsonSerializer.Deserialize<List<T>>(jsonString);
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
                else Console.WriteLine("Det finns inga sparade objekt!");
            }
            return null;
        }
    }
}