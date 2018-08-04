using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorkOfTheTrainingPart.Structs;

namespace TheWorkOfTheTrainingPart.BL
{
    class UsersChoise
    {
        #region Users_Enter_Of_Scene_1
        public static void ChangeTheValueDependingOnUsersEntry(ref byte valueCounter, ConsoleKey key, ref byte selectedValue)  // Change the value depending on users enter
        {
            switch (key)  // Equal the value
            {
                case ConsoleKey.DownArrow:  
                    ++valueCounter;  // Increment the value of counter
                    break;
                case ConsoleKey.UpArrow:
                    --valueCounter;  // Decrement the value of counter
                    break;
                case ConsoleKey.Enter:
                    SelectedLineFix(ref selectedValue, valueCounter);  // Change the value depending on position cursor
                    break;
                case ConsoleKey.Escape:
                    valueCounter = 5;  // The value for exit 
                    break;
            }
        }
        public static void SelectedLineFix(ref byte selectedValue, byte valueCounter)  // Change the value that knows line of users enter
        {
            switch (valueCounter)  // Check the value
            {
                case 0:
                    selectedValue = 1;  // Initialization the value
                    break;
                case 1:
                    selectedValue = 2;  // Initialization the value
                    break;
                case 2:
                    selectedValue = 3;  // Initialization the value
                    break;
                case 3:
                    selectedValue = 4;  // Initialization the value
                    break;
                case 4:
                    selectedValue = 5;  // Initialization the value
                    break;
            }
        }
        #endregion

        #region Users_Enter_Of_List_Of_Students
        public static void UsersSelectedMove(ref byte valueOfChoise, ConsoleKey key, ref uint counterOfY, Student[] student, byte valueForExit)  // Check users enter
        {
            switch (key)  // if the value equal
            {
                case ConsoleKey.UpArrow:
                    --valueOfChoise;  // Decrement the value of choise
                    --counterOfY;  // Decrement the position cursor Y
                    break;
                case ConsoleKey.DownArrow:
                    ++valueOfChoise;  // Increment the value of choise 
                    ++counterOfY;  // Increment the position cursor Y
                    break;
                case ConsoleKey.Escape:
                    valueForExit = 5;  // Initialization the value for exit
                    break;
            }
            if (valueOfChoise == (student.Length + 1))  // If the condition is true
            {
                --valueOfChoise;  // Decrement the value of choise
                --counterOfY;  // Decrement the position cursor Y
            }
            if (valueOfChoise > student.Length)
            {
                ++valueOfChoise;  // Increment the value of choise 
                ++counterOfY;  // Increment the position cursor Y
            }
        }
        #endregion

        #region Users_Enter_Add_The_Student
        public static void AcceptUsersEnter(out byte value, byte x, byte y,ref ConsoleKey key)  // Accept the value
        {
            do
            {
                Console.SetCursorPosition(x, y);
                value = Convert.ToByte(Console.ReadLine());  // Read the value and initialization
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey().Key;
                    return;
                }
            } while (value == 0);
        }
        public static void AcceptUsersEnter(out uint value, byte x, byte y)  // Accept the value
        {
            do
            {
                Console.SetCursorPosition(x, y);
                value = Convert.ToUInt32(Console.ReadLine());  // Read the value and initialization
                
            } while (value == 0);
        }
        public static void AcceptUsersEnter(out string value, byte x, byte y, ref ConsoleKey key)  // Accept the value
        {
            Console.SetCursorPosition(x, y);
            value = Convert.ToString(Console.ReadLine());  // Read the value and initialization
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey().Key;
                return;
            }
        }
        public static void AcceptUsersEnter(out char value, byte x, byte y)  // Accept the value
        {
            do
            {
                Console.SetCursorPosition(x, y);
                value = Console.ReadKey().KeyChar;  // Read the value and initialization
                Console.ReadKey();
            } while ((value != 'M') && (value != 'W'));
        }
        #endregion
    }
}
