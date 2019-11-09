using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    public class MapObject : IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

        public MapObject(char symbol, PositionOnMap position)
        {
            Type = "MapObject";
            Symbol = symbol;
            Position = position;
        }

        public MapObject()
        {

        }
    }
}
