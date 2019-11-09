using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    public interface IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

    }
}
