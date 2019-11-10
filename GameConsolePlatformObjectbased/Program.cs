using GameConsolePlatformObjectbased.ConsoleClasses.Levels;
using GameConsolePlatformObjectbased.Map.MapObjects;
using System;
using System.Collections.Generic;

namespace GameConsolePlatformObjectbased
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Level level = new Level();
            
            level.GenerateLevelAsCharArray(Level.BaseLevelAsString());
            Map.MapCreator.LoadMapWithObjects(level);
            ConsoleClasses.DrawLevel.PrintMap(Map.MapCreator.LoadMapWithObjects(level));
;

            Console.ReadLine();
        }

        public static void Test()
        {
            List<IMapObject> listOfObjects = new List<IMapObject>();

            MapObject mapObject = new MapObject();
            WallObject wallObject = new WallObject();
            GroundObject groundObject = new GroundObject();

            listOfObjects.Add(mapObject);
            listOfObjects.Add(wallObject);


        }
    }
}
