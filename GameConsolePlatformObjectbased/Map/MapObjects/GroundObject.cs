using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    public class GroundObject :IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

        public GroundObject(char symbol, PositionOnMap position)
        {
            Type = "GroundObject";
            Symbol = symbol;
            Position = position;
        }

        public GroundObject()
        {

        }
    }
}
