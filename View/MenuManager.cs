using System;
using projekt1.Model;
using System.Collections.Generic;
using projekt1.ListExt;
using projekt1.ObjectExt;
namespace projekt1.View {
    class MenuManager {
        Menu menu = new Menu();
        public MenuManager() {
            ShowMainMenu();
        }
        public void ShowConvMenu() {
            object[,] convMenuItems = new object[,] {
                {"Konvertera från F till C och K", (Action)Degrees.ConvertFromF},
                {"Konvertera från C till F och K", (Action)Degrees.ConvertFromC},
                {"Konvertera från K till F och C", (Action)Degrees.ConvertFromK},
                {"Återgå till huvudmenyn", (Action)ShowMainMenu},
                {"Avsluta", (Action)Close}

            };
            menu.ShowMenu(convMenuItems);

        }
        public void ShowOhmsMenu() {
            object[,] convMenuItems = new object[,] {
                {"Räkna ut R", (Action)Ohms.CalcR},
                {"Räkna ut V", (Action)Ohms.CalcV},
                {"Räkna ut I", (Action)Ohms.CalcI},
                {"Återgå till huvudmenyn", (Action)ShowMainMenu},
                {"Avsluta", (Action)Close}

            };
            menu.ShowMenu(convMenuItems);

        }


        public void ShowMainMenu() {
            object[,] menuItems = new object[,] {
                {"Konvertera grader", (Action)ShowConvMenu},
                {"Ohms lag", (Action)ShowOhmsMenu},
                {"Figurer", (Action)ShowShapesMenu},
                {"Hastighet", (Action)ShowSpeedMenu},
                {"Konvertera enheter", (Action)ShowMetricConvMenu},
                {"Sparade figurer", (Action)ShowSavedShapesMenu},
                {"Avsluta", (Action)Close}

            };

            menu.ShowMenu(menuItems);
        }

        public void ShowShapesMenu() {
            object[,] menuItems = new object[,] {
                {"Räkna ut arean på en rektangel", (Action)View.Shape.CalcR},
                {"Räkna ut arean på en triangeln", (Action)View.Shape.CalcT},
                {"Räkna ut arean på en cirkel", (Action)View.Shape.CalcC},
                {"Räkna ut arean och volymen på en kub", (Action)View.Shape.CalcCube},
                {"Räkna ut volymen på en pyramid", (Action)View.Shape.CalcPyramid},
                {"Räkna ut volymen på en sfär", (Action)View.Shape.CalcSphere},
                {"Återgå till huvudmenyn", (Action)ShowMainMenu},
                {"Avsluta", (Action)Close}

            };

            menu.ShowMenu(menuItems);
        }

        public void ShowSpeedMenu() {
            object[,] menuItems = new object[,] {
                {"Räkna ut hastigheten", (Action)View.Speed.CalcSpeed},
                {"Räkna ut tiden", (Action)View.Speed.CalcTime},
                {"Räkna ut sträckan", (Action)View.Speed.CalcDistance},
                {"Återgå till huvudmenyn", (Action)ShowMainMenu},
                {"Avsluta", (Action)Close}

            };

            menu.ShowMenu(menuItems);
        }

        public void ShowMetricConvMenu() {
            object[,] menuItems = new object[,] {
                {"Konvertera tum till cm, fot, yard och m", (Action)View.MetricConverter.ConvertFromTum},
                {"Konvertera från cm till tum, fot, yard och m", (Action)View.MetricConverter.ConvertFromCm},
                {"Konvertera fot till cm, tum, yard och m", (Action)View.MetricConverter.ConvertFromFoot},
                {"Konvertera yard till cm, tum, fot och m", (Action)View.MetricConverter.ConvertFromYard},
                {"Konvertera m till cm, tum, fot och yard", (Action)View.MetricConverter.ConvertFromMeter},
                {"Återgå till huvudmenyn", (Action)ShowMainMenu},
                {"Avsluta", (Action)Close}

            };

            menu.ShowMenu(menuItems);
        }

        public void ShowSavedShapesMenu() {
            List<Rectangle> rectangleObjs = Json.ReturnObjList<Rectangle>("View/json/rectangle.json");
            List<Pyramid> pyramidObjs = Json.ReturnObjList<Pyramid>("View/json/pyramid.json");
            List<Cube> cubeObjs = Json.ReturnObjList<Cube>("View/json/cube.json");
            List<Triangle> triangleObjs = Json.ReturnObjList<Triangle>("View/json/triangle.json");
            List<Sphere> sphereObjs = Json.ReturnObjList<Sphere>("View/json/sphere.json");
            List<Circle> circleObjs = Json.ReturnObjList<Circle>("View/json/circle.json");
            int objsCount = rectangleObjs.NoNullCount() + pyramidObjs.NoNullCount() + cubeObjs.NoNullCount() + triangleObjs.NoNullCount() + sphereObjs.NoNullCount() + circleObjs.NoNullCount();
            object[,] menuItems = new object[objsCount + 2, objsCount + 2];
            int i;
            for (i = 0; i < menuItems.GetLength(0) - 2; i++) {
                if (i < rectangleObjs.NoNullCount()) {
                    menuItems[i, 0] = $"Räkna ut arean på en {rectangleObjs[i].Width} x {rectangleObjs[i].Height} stor rektangel ";
                    menuItems[i, 1] = (Action)rectangleObjs[i].ConsoleWriteToString;
                }
                if (i == rectangleObjs.NoNullCount()) {
                    int j;
                    for (j = 0; j < pyramidObjs.NoNullCount(); j++) {
                        menuItems[i + j, 0] = $"Räkna ut volymen på en pyramid med bredd på {pyramidObjs[j].BWidth}, längd på {pyramidObjs[j].BLenght}, höjd på {pyramidObjs[j].Height} ";
                        menuItems[i + j, 1] = (Action)pyramidObjs[j].ConsoleWriteToString;
                    }
                    i += j;
                    int cubeI;
                    for (cubeI = 0; cubeI < cubeObjs.NoNullCount(); cubeI++) {
                        menuItems[i + cubeI, 0] = $"Räkna ut arean och volymen på en kub som är {cubeObjs[cubeI].Length} cm lång ";
                        menuItems[i + cubeI, 1] = (Action)cubeObjs[cubeI].ConsoleWriteToString;
                    }
                    i += cubeI;

                    int triangleI;
                    for (triangleI = 0; triangleI < triangleObjs.NoNullCount(); triangleI++) {
                        menuItems[i + triangleI, 0] = $"Räkna ut arean på en triangel med en bas på {triangleObjs[triangleI].B} cm och en höjd på {triangleObjs[triangleI].B} cm ";
                        menuItems[i + triangleI, 1] = (Action)triangleObjs[triangleI].ConsoleWriteToString;
                    }
                    i += triangleI;

                    int sphereI;
                    for (sphereI = 0; sphereI < sphereObjs.NoNullCount(); sphereI++) {
                        menuItems[i + sphereI, 0] = $"Räkna ut volymen på en sfär med en radie på {sphereObjs[sphereI].R} cm";
                        menuItems[i + sphereI, 1] = (Action)sphereObjs[sphereI].ConsoleWriteToString;
                    }
                    i += sphereI;

                    int circleI;
                    for (circleI = 0; circleI < circleObjs.NoNullCount(); circleI++) {
                        menuItems[i + circleI, 0] = $"Räkna ut arean på en cirkel med en radie på {circleObjs[circleI].R} cm";
                        menuItems[i + circleI, 1] = (Action)circleObjs[circleI].ConsoleWriteToString;
                    }
                    i += circleI;

                }

            }
            menuItems[objsCount, 0] = $"Återgå till huvudmenyn";
            menuItems[objsCount, 1] = (Action)ShowMainMenu;
            menuItems[objsCount + 1, 0] = $"Avsluta";
            menuItems[objsCount + 1, 1] = (Action)Close;
            menu.ShowMenu(menuItems);

        }

        public void Close() {
            Environment.Exit(0);
        }
    }
}