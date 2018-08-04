using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorkOfTheTrainingPart.UI
{
    class PrintToConsole
    {
        #region Arrays_Of_Position_Cursor
        public static byte[] yCursorPosition = {(byte)((Console.LargestWindowHeight / 2) + 1),
                                                (byte)((Console.LargestWindowHeight / 2) + 3),
                                                (byte)((Console.LargestWindowHeight / 2) + 5),
                                                (byte)((Console.LargestWindowHeight / 2) + 7),
                                                (byte)((Console.LargestWindowHeight / 2) + 9)};  // The array of positioncursor by X

        public static byte[] xCursorPosition = {(byte)((Console.LargestWindowWidth / 2) - 10),
                                                (byte)((Console.LargestWindowWidth / 2) - 6),
                                                (byte)((Console.LargestWindowWidth / 2) - 20),
                                                (byte)((Console.LargestWindowWidth / 2) - 23),
                                                (byte)((Console.LargestWindowWidth / 2) - 3)};  // The array of positioncursor by Y
        #endregion

        #region UI_Scene_1
        public static void PrintTheGrayTiles(char space)  // Print the graph on console
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;  // Change the color
            for (int yCursorPosition = 0; yCursorPosition < (Console.LargestWindowHeight - 1); yCursorPosition += 2)  // Bust position Y
            {
                for (int xCursorPosition = 0; xCursorPosition < (Console.LargestWindowWidth - 1); xCursorPosition += 2)  // Bust position X
                {
                    Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change cursor position
                    Console.WriteLine(space);  // Print the char
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;  // Change the color
        }
        public static void ClearPlaceForText(char space)  // Clear place on console for visible text 
        {
            byte endSideByX = (byte)((Console.LargestWindowWidth / 2) + 38);  // Right side for square
            byte endSideByY = (byte)((Console.LargestWindowHeight / 2) + 10);  // Bottom side for square

            byte xCursorPosition = (byte)((Console.LargestWindowWidth / 3) - 1);  // FIrst position by X
            byte yCursorPosition = (byte)((Console.LargestWindowHeight / 3) - 4);  // FIrst position by Y
            byte startPositionX = xCursorPosition;  // Initialization start position cursor by X

            for (; yCursorPosition < endSideByY; ++yCursorPosition)  // Cycle bust position cursor by Y
            {
                for (xCursorPosition = startPositionX; xCursorPosition < endSideByX; ++xCursorPosition)  // Cycle bust position cursor by X
                {
                    Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change the position cursor
                    Console.WriteLine(space);  // Print the char
                }
            }
        }
        public static void PrintLogoApplication()  // Print application name 
        {
            byte xCursorPosition = (byte)(Console.LargestWindowWidth / 3);  // Start position cursor by X
            byte yCursorPosition = (byte)(Console.LargestWindowHeight / 3);  // Start position cursor by Y

            Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change the cursor position
            Console.WriteLine("███─█──█─███────████──███─████─█──█─███──────────████─███─███─███─████─███");  // Print the part of logo

            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change the cursor position
            Console.WriteLine("─█──█──█─█──────█──██─█───█──█─██─█─█────────────█──█─█───█────█──█──█─█");  // Print the part of logo

            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change the cursor position
            Console.WriteLine("─█──████─███────█──██─███─████─█─██─███──────────█──█─███─███──█──█────███");  // Print the part of logo

            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change the cursor position
            Console.WriteLine("─█──█──█─█──────█──██─█───█──█─█──█───█──────────█──█─█───█────█──█──█─█");  // Print the part of logo

            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change the cursor position
            Console.WriteLine("─█──█──█─███────████──███─█──█─█──█─███──────────████─█───█───███─████─███");  // Print the part of logo
        }
        public static void DisplaySelectedOnTheScreen(byte valueChoise)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            switch (valueChoise)
            {
                case 0:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);
                    Console.WriteLine("The list of all students");
                    break;
                case 1:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);
                    Console.WriteLine("Add the student");
                    break;
                case 2:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);
                    Console.WriteLine("Transfer the student to another group");
                    break;
                case 3:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);
                    Console.WriteLine("Output information for a particular student");
                    break;
                case 4:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);
                    Console.WriteLine("Exit");
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintTheList(byte valueChoise)  // Print the full list
        {
            do  // Required cycle of choise
            {
                switch (valueChoise)  // If variable equal certain value
                {
                    case 0:
                        Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change cursor position
                        Console.WriteLine("The list of all students");  // Print the text
                        break;
                    case 1:
                        Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change cursor position
                        Console.WriteLine("Add the student");  // Print the text
                        break;
                    case 2:
                        Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change cursor position
                        Console.WriteLine("Transfer the student to another group");  // Print the text
                        break;
                    case 3:
                        Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change cursor position
                        Console.WriteLine("Output information for a particular student");  // Print the text
                        break;
                    case 4:
                        Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change cursor position
                        Console.WriteLine("Exit");  // Print the text
                        break;
                }
                ++valueChoise;  // Increment the value
            } while (valueChoise != 5);  // Exit from cycle
        }
        public static void ClearBackgroundLine(byte valueChoise)  // Print line without background color
        {
            switch (valueChoise)  // If the value equal
            {
                case 0:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change the cursor position
                    Console.WriteLine("The list of all students");  // Print the line on console
                    break;
                case 1:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change the cursor position
                    Console.WriteLine("Add the student");  // Print the line on console
                    break;
                case 2:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change the cursor position
                    Console.WriteLine("Transfer the student to another group");  // Print the line on console
                    break;
                case 3:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change the cursor position
                    Console.WriteLine("Output information for a particular student");  // Print the line on console
                    break;
                case 4:
                    Console.SetCursorPosition(xCursorPosition[valueChoise], yCursorPosition[valueChoise]);  // Change the cursor position
                    Console.WriteLine("Exit");  // Print the line on console
                    break;
            }
        }
        #endregion
    }
}
