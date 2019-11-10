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
                    "|   @                                                                                                          |" +
                    "|                                                                                                              |" +
                    "|TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT|" +
                    "|                                                                                                              |" +
                    "|                                                                                                              |" +
                    "|______________________________________________________________________________________________________________|";
        }
        public static string SmallMapAsString()
        {
            //return "____" +
            //       "|  |" +
            //       "|  |" +
            //       "|  |" +
            //       "TTTT";
            return " |  " +
                   "  T " +
                   "    " +
                   "    " +
                   "    ";

        }

        public Level()
        {
            LevelAsCharArray = new char[28,112];
        }



        public void GenerateLevelAsCharArray(string levelAsString)
        {
            //bytte plats på 0 och (1).
            for (int y = 0; y < LevelAsCharArray.GetLength(0); y++)
            {
                for (int x = 0; x < LevelAsCharArray.GetLength(1); x++)
                {
                    //bytte plats på x och y i LevelAsCharArray.
                    LevelAsCharArray[y, x] = levelAsString[y * LevelAsCharArray.GetLength(1) + x];
                }
            }
        }



    }
}
