using GameConsolePlatformObjectbased.ConsoleClasses.Levels;
using GameConsolePlatformObjectbased.Map.MapObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map
{
    public class MapCreator
    {
        //public IMapObject[,] level1 = new IMapObject[28,112];


        public static IMapObject[,] LoadMapWithObjects(Level level)
        {
            IMapObject[,] objectRenderedMap = new IMapObject[28, 112];

            for (int y = 0; y < level.LevelAsCharArray.GetLength(1); y++)
            {
                for (int x = 0; x < level.LevelAsCharArray.GetLength(0); x++)
                {
                    PositionOnMap currentPosition = new PositionOnMap { X = x, Y = y };
                    char symbol = level.LevelAsCharArray[x, y];

                    switch (symbol)
                    {
                        case '|':
                            objectRenderedMap[x, y] = new WallObject(symbol, currentPosition);
                            break;
                        case '@':
                            objectRenderedMap[x, y] = new PlayerObject(symbol, currentPosition);
                            break;
                        case 'T':
                            objectRenderedMap[x, y] = new GroundObject(symbol, currentPosition);
                            break;
                        case ' ':
                            objectRenderedMap[x, y] = new MapObject(symbol, currentPosition);
                            break;
                        case '_':
                            objectRenderedMap[x, y] = new RoofObject(symbol, currentPosition);
                            break;
                        default:
                            break;
                    }
                }
            }
            return objectRenderedMap;
        }

    }
}
