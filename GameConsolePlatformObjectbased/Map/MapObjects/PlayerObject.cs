using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.Map.MapObjects
{
    class PlayerObject : IMapObject
    {
        public string Type { get; set; }
        public char Symbol { get; set; }
        public int Value { get; set; }
        public PositionOnMap Position { get; set; }

        public string Name { get; set; }
        public string Head{ get; set; }
        public string Body { get; set; }

        public PlayerObject(char symbol, PositionOnMap position)
        {
            Symbol = symbol;
            Position = position;
        }

        public PlayerObject()
        {

        }

    }
}
