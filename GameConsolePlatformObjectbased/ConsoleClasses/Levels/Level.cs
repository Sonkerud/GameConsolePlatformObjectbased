using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlatformObjectbased.ConsoleClasses.Levels
{
    public class Level
    {
        public char[,] LevelAsCharArray { get; set; }
        public static string BaseLevelAsString()
        {
            return  " ______________________________________________________________________________________________________________ " +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|______________________________________________________________________________________________________________|";
        }

        public Level()
        {
            LevelAsCharArray = new char[28,112];
        }

        public void GenerateLevelAsCharArray(string levelAsString)
        {
            for (int y = 0; y < LevelAsCharArray.GetLength(1); y++)
            {
                for (int x = 0; x < LevelAsCharArray.GetLength(0); x++)
                {
                    LevelAsCharArray[x, y] = levelAsString[y * LevelAsCharArray.GetLength(0) + x];
                }
            }
        }



    }
}
