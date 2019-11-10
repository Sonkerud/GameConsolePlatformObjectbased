using GameConsolePlatformObjectbased.Map.MapObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.ConsoleClasses
{
    class DrawLevel
    {
            public static void PrintMap(IMapObject[,] mapWithObjects)
            {
                for (int y = 0; y < mapWithObjects.GetLength(0); y++)
                {
                    for (int x = 0; x < mapWithObjects.GetLength(1); x++)
                    {
                        Console.Write(mapWithObjects[y, x].Symbol);
                    }
                    Console.WriteLine();
                }
            }
    }
}
