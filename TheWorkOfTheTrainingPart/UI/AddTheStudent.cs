using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorkOfTheTrainingPart.UI
{
    class AddTheStudent
    {
        public static void FrameOnConsole(char spacebar)  // Print the frame on console
        {
            Console.BackgroundColor = ConsoleColor.White;  // Change the color of background
            for (int yCursorPosition = 0; yCursorPosition < (Console.LargestWindowHeight - 1); yCursorPosition++)  // Cycle of bust position cursor by Y
            {
                for (int xCursorPosition = 0; xCursorPosition < (Console.LargestWindowWidth - 1); xCursorPosition++)  // Cycle of bust position cursor by X
                {
                    if ((xCursorPosition > 8) && (xCursorPosition < (Console.LargestWindowWidth - 10)) && (yCursorPosition > 4) && (yCursorPosition < (Console.LargestWindowHeight - 6)))  // If the condition true
                    {
                        // Do nothing
                    }
                    else  // If the condition false, thanprint the char
                    {
                        Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change the position of cursor
                        Console.WriteLine(spacebar);  // Print the char
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;  // Change the color of background
        }
        public static void LogoAddTheStudent()  // Print logo on console
        {
            byte xCursorPosition = (byte)(Console.LargestWindowWidth / 3 - 5);  // Set cursor position by X
            byte yCursorPosition = 0;  // Set cursor position by Y
            Console.BackgroundColor = ConsoleColor.Black;  // Change the color

            Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change cursor position
            Console.WriteLine("███████████████████████████████████████████████████████████████████████████████");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█────█────██────████████████───█─██─█───████████───█───█─█─█────██───█─██─█───█");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█─██─█─██──█─██──████████████─██─██─█─██████████─████─██─█─█─██──█─███──█─██─██");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█────█─██──█─██──████████████─██────█───████████───██─██─█─█─██──█───█─█──██─██");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█─██─█─██──█─██──████████████─██─██─█─████████████─██─██─█─█─██──█─███─██─██─██");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█─██─█────██────█████████████─██─██─█───████████───██─██───█────██───█─██─██─██");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("███████████████████████████████████████████████████████████████████████████████");  // Print the text
        }
        public static void RequestTheUsersEnter(string nameOfLine, byte cursorPositionX, byte cursorPositionY)  // Request the information of line
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);  // Change the cursor position
            Console.Write(nameOfLine);   // Print the string
        }
        public static void ClearTheUsersEnter( byte cursorPositionX, byte[] cursorPositionY)  // Clear the information of line
        {
            for (int counter = 0; counter < cursorPositionY.Length; counter++)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY[(byte)counter]);  // Change the cursor position
                Console.Write("                         ");   // Print the string
            }
            
        }
    }
}
