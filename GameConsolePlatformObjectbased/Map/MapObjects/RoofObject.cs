using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    public class RoofObject : IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

        public RoofObject(char symbol, PositionOnMap position)
        {
            Type = "Roof";
            Symbol = symbol;
            Position = position;
        }

        public RoofObject()
        {

        }

    }
}
