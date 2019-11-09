using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    public class WallObject : IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

        public WallObject(char symbol, PositionOnMap position)
        {
            Type = "WallObject";
            Symbol = symbol;
            Position = position;
        }

        public WallObject()
        {

        }

    }
}
