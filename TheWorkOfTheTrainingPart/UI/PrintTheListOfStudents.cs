using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorkOfTheTrainingPart.Structs;

namespace TheWorkOfTheTrainingPart.UI
{
    class PrintTheListOfStudents
    {
        #region Array
        #region Array_Of_Position_Cursor
        public static uint[] xCursorPosition = {(byte)((Console.LargestWindowWidth / 10) + 3), (byte)(Console.LargestWindowWidth / 2), (byte)((Console.LargestWindowWidth / 2) + 30)};  // Coordinate X cursor position
        public static uint[] yCursorPosition = { (byte)(Console.LargestWindowHeight / 3), (byte)((Console.LargestWindowHeight / 3) + 2), (byte)((Console.LargestWindowHeight / 3) + 4),
                                                 (byte)((Console.LargestWindowHeight / 3) + 6), (byte)((Console.LargestWindowHeight / 3) + 8), (byte)((Console.LargestWindowHeight / 3) + 10),
                                                 (byte)((Console.LargestWindowHeight / 3) + 12), (byte)((Console.LargestWindowHeight / 3) + 14), (byte)((Console.LargestWindowHeight / 3) + 16),
                                                 (byte)((Console.LargestWindowHeight / 3) + 18), (byte)((Console.LargestWindowHeight / 3) + 20), (byte)((Console.LargestWindowHeight / 3) + 22),
                                                 (byte)((Console.LargestWindowHeight / 3) + 24)};  // Coordinate Y cursor position
        #endregion

        public static string[] columnOfOption = {"Gender :", "Identification Code :", "Average Score :", "Serial number of passport :", "Number of student :", "Year :", "Group"};  // The array of option by student
        #endregion

        #region Outside_Fragment_Of_List_Students
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
        public static void LogoListOfStudents()  // Print logo on console
        {
            byte xCursorPosition = (byte)(Console.LargestWindowWidth / 3 - 10);  // Set cursor position by X
            byte yCursorPosition = 0;  // Set cursor position by Y
            Console.BackgroundColor = ConsoleColor.Black;  // Change the color

            Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change cursor position
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("█───█─██─█───████████─███───█───█───█████────█───████████───█───█─█─█────██───█─██─█───█───█");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("██─██─██─█─██████████─████─██─████─██████─██─█─██████████─████─██─█─█─██──█─███──█─██─██─███");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("██─██────█───████████─████─██───██─██████─██─█───████████───██─██─█─█─██──█───█─█──██─██───█");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("██─██─██─█─██████████─████─████─██─██████─██─█─████████████─██─██─█─█─██──█─███─██─██─████─█");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("██─██─██─█───████████───█───█───██─██████────█─██████████───██─██───█────██───█─██─██─██───█");  // Print the text
            Console.SetCursorPosition(xCursorPosition, ++yCursorPosition);  // Change cursor position
            Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████");  // Print the text
        }
        public static void MainColumnWithOption(uint countOfX, uint countOfY)  // Print the column of option
        {
            for (int counter = 0; counter < columnOfOption.Length; ++counter, countOfY += 2)  // Cycle of bust 
            {
                Console.SetCursorPosition((int)xCursorPosition[countOfX + 1], (int)yCursorPosition[countOfY]);  // Change the cursor position
                Console.WriteLine(columnOfOption[counter]);  // Print the text on console
            }
        }
        public static void MainLineWithOption(string text)  // Print Main line on console
        {
            byte xCursorPosition = (byte)(Console.LargestWindowWidth / 10);  // Change the cursor position by X
            byte yCursorPosition = (byte)(Console.LargestWindowHeight / 4);  // Change the cursor position by Y
            Console.SetCursorPosition(xCursorPosition, yCursorPosition);  // Change the cursor position
            Console.WriteLine(text);  // Print the text
        }
        public static void ListOfStudents(Student[] student, uint counterOfX, uint counterOfY, int counter)  // Print the students on console
        {
            for (; counterOfY < yCursorPosition.Length; ++counter, ++counterOfY)  // Cycle of bust counter
            {
                if (counter < student.Length)  // If the size less
                {
                    Console.SetCursorPosition((int)xCursorPosition[counterOfX], (int)yCursorPosition[counterOfY]);  // Change the cursor position 
                    Console.WriteLine((counter + 1) + "\t" + student[counter].name + "\t     " + student[counter].surname);  // Print the text on console
                }
            }
            counterOfY = 0;  // Nulled  the value
        }

        #endregion

        #region Method_UI_For_CHange_Choise
        public static void NonSelectedLineOfStudent(byte valueOfCounter, Student[] student, uint counterOfX, uint counterOfY)  // Print The non selected line
        {
            if (valueOfCounter >= student.Length)  // If the condition true
            {
                --valueOfCounter;  // Decrement the value of counter
                --counterOfY;  // Decrement of position cursor Y
            }
            Console.SetCursorPosition((int)xCursorPosition[counterOfX], (int)yCursorPosition[counterOfY]);  // Change the cursor position 
            Console.WriteLine((valueOfCounter + 1) + "\t" + student[valueOfCounter].name + "\t     " + student[valueOfCounter].surname);  // Print the text on console
        }
        public static void SelectedLineOfStudent(byte valueOfCounter, Student[] student, uint counterOfX, uint counterOfY)  // Print the selected line
        {
            if (valueOfCounter >= student.Length)  // If the value true
            {
                --valueOfCounter;  // Decrement Of the value
                --counterOfY;  // Decrement the counter by Y
            }

            if (counterOfY < yCursorPosition.Length)  // If the condition true
            {
                Console.BackgroundColor = ConsoleColor.White;  // Change the color of background
                Console.ForegroundColor = ConsoleColor.Black;  // Change the color of text
                Console.SetCursorPosition((int)xCursorPosition[counterOfX], (int)yCursorPosition[counterOfY]);  // Change the cursor position 
                Console.WriteLine((valueOfCounter + 1) + "\t" + student[valueOfCounter].name + "\t     " + student[valueOfCounter].surname);  // Print the text on console
                Console.BackgroundColor = ConsoleColor.Black;  // Change the color of background
                Console.ForegroundColor = ConsoleColor.White;  // Change the color of text
            }
            else // if the value false
            {
                counterOfY = 0;  // Nulled the position Y
                ClearOfList(counterOfX, counterOfY);  // Clear the list of students
                ListOfStudents(student, counterOfX, counterOfY, valueOfCounter);  // Print the new list of students
                SelectedLineOfStudent(valueOfCounter, student, counterOfX, counterOfY);  // Print the selected line
            }
        }
        public static void ClearOfList(uint counterOfX, uint counterOfY)  // Clear the list of students
        {
            for (int counter = 0; counter < yCursorPosition.Length; ++counter, ++counterOfY)  // Cycle of bust counter
            {
                Console.SetCursorPosition((int)xCursorPosition[counterOfX], (int)yCursorPosition[counterOfY]);  // Change the cursor position 
                Console.WriteLine("\t\t\t\t\t");  // Print the text on console
            }
            counterOfY = 0;  // Nulled the value of position Y
        }

        #endregion

        #region Methods_UI_For_Change_Information_Of_Student
        public static void PrinTheColomnOfOptionStudent(uint countOfX, uint countOfY, byte counter, Student[] students)  // Print the main information of students
        {
            if (counter == 66)  // If the condition is true
            {
                return;  // Exit from method
            }
            countOfY = 0;  // Nulled the value
            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].gender);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].identificationCode);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].averageScore);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].serialNumberOfPassport);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].numberOfStudent);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].year);  // Print the text on console
            countOfY += 2;  // Add two position on Y

            Console.SetCursorPosition((int)xCursorPosition[countOfX + 2], (int)yCursorPosition[countOfY]);  // Change the cursor position
            Console.WriteLine(students[counter].numberOfGroup);  // Print the text on console
        }
        public static void ClearTheColumn(uint countOfX, uint countOfY, char spacebar)  // Clear the information from student
        {
            countOfY = 0;  // Nulled the value position Y
            for (byte counter = 0; counter < columnOfOption.Length; countOfY += 2, ++counter)  // Cycle of bust 
            {
                Console.SetCursorPosition((byte)xCursorPosition[countOfX + 2], (byte)yCursorPosition[countOfY]);  // Change the cursor position
                Console.WriteLine(spacebar + "                ");  // Print the space for clear
            }
        }
        #endregion
    }
}
