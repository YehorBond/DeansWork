using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorkOfTheTrainingPart.BL;
using TheWorkOfTheTrainingPart.UI;
using TheWorkOfTheTrainingPart.Structs;

namespace TheWorkOfTheTrainingPart
{
    class Program
    {
        #region Scene_1
        #region Array

        #region Array_Of_Students_Name
        public static string[] nameOfStudensMan = {"Андрей", "Артем", "Ахмед", "Егор", "Иван", "Алексей", "Степан", "Денис", "Джон", "Никита", "Ян",
                                                   "Роман", "Александр", "Марк", "Влад", "Карим", "Юсуф", "Константин", "Олег", "Антон", "Вячеслав", "Тимур",
                                                   "Дмитрий", "Егор", "Евгений", "Василий", "Степан", "Валентин", "Майкл", "Хюго", "Боб", "Джейсон", "Дэмиан"};  // Array  names of man students

        public static string[] nameOfStudentsWoman = {"Алина", "Галина", "Александра", "Римма", "Карина", "Элайза", "Яна", "Екатерина", "Анастасия", "Кира", "Римма",
                                                      "Татьяна", "Виктория", "Оксана", "Ксения", "Любовь", "Вера", "Надежда", "Екатерирна", "Мила", "Анна", "Алина",
                                                      "Вероника", "Анна", "Роберта", "Дженни", "Светлана", "Эмилия", "Карина", "Евгения", "Раиса", "Эйприл", "Кара",};  // Array  names of woman students
        #endregion

        #region Array_Of_Students_Surname
        public static string[] surnameOfStudentsMan = {"Пащенко", "Каридов", "Снигерев", "Иванов", "Карманов", "Левак", "Ковчун", "Лапита", "Морев", "Словко", "Мацко",
                                                       "Сила", "Малина", "Конь", "Афендеев", "Тополь", "Сливков", "Микс", "Кнут", "Липов", "Сорока", "Карпенко", "Снерв",
                                                       "Кола", "Слоу", "Кноу", "Сноу", "Риммов", "Сальто", "Киркоров", "Символ", "Крот", "Майор", "Стропилов", "Комп"};  // Array surnames of man students

        public static string[] surnameofStudentsWoman = {"Андреевна", "Коваленко", "Строк", "Слим", "Полт", "Мелот", "Орк", "Бондарева", "Курвова", "Мурвова", "Силова",
                                                         "Молотова", "Комбинова", "Лапкова", "Банк", "Пароу", "Вольт", "Торива", "Сирова", "Милова", "Гелдо", "Тилок",
                                                         "Соло", "Цинк", "Ферова", "Картонка", "Олкина", "Прова", "Кису", "Мивоу", "ЛАмарова", "Стук", "Дол", "Рик"};  // Array surnames of woman students
        #endregion

        #region Array_Of_All_Value_By_Students
        public static int numberElementInArray = 66;
        public static uint[] arrayIdentificationCodes = new uint[numberElementInArray];  // Array of codes all students

        public static byte[] arrayOfAverageScore = new byte[numberElementInArray];  // Array of score all students

        public static string[] arrayOfSerialNumberPassport = new string[numberElementInArray];  // Array of the serial number passport

        public static uint[] arrayNumberOfStudent = new uint[numberElementInArray];
        #endregion

        #region Array_Of_All_Value_By_Group
        public static Student[] student = new Student[numberElementInArray];

        public static Group[] group = new Group[6];
        #endregion

        #endregion

        #region Constant_Value
        const char spacebar = ' ';  // The char of space for clean and print 
        #endregion

        #region Variable
        public static byte counter = 0;  // The counter for choise by user
        public static ConsoleKey key;  // The buttom of users enter
        public static byte usersSelectedValue;  // The value which user selected 
        #endregion
        #endregion

        #region Variable_Of_List_Of_Students
        public static uint counterOfX = 0;  // The counter of position cursor X
        public static uint counterOfY = 0;  // The counter of position cursor Y
        public static int counterOfBust = 0;  // The counter of bust
        public static byte valueForExit = 0;  // The value for exit from cycle
        #endregion

        #region Add_The_Student
        #region Array_Of_Position_Cursor
        public static byte[] arrayPositionCursorX = {(byte)(Console.LargestWindowWidth / 3), (byte)((Console.LargestWindowWidth / 3) + 40)};
        public static byte[] arrayPositionCursorY = new byte[10];
        #endregion

        #region Variable_Add_The_Student
        public static string name, surname, serialNumberOfPassport;  // Name and surname of student, serial number   
        public static char gender;  // Sex of student
        public static uint identificationCode = 0;  // Identification code include by ten numbers

        public static byte averageScore = 0, numberOfGroup = 0, year = 0;  // System of score from 60 to 100 and number of group, year
        public static uint numberOfStudent = 0;  // Student has number in academy, it is four numbers
        #endregion
        #endregion

        static void Main()  // Start programe
        {
            #region Setting_Console
            Console.SetWindowPosition(0, 0);  // Change the position of the window to the upper left corner
            Console.WindowHeight = Console.LargestWindowHeight;  // Set the height of the console to fit the screen
            Console.WindowWidth = Console.LargestWindowWidth;  // Set the width of the console to fit the screen

            Console.BufferHeight = Console.WindowHeight;  // Equate the height of the buffer to the screen height
            Console.BufferWidth = Console.WindowWidth;  // Equate the width of the buffer to the screen width

            Console.CursorVisible = false;  // Cursor is not visible

            #endregion

            #region Initialization_Array
            InitialArrays.InitialIdentificationCode(arrayIdentificationCodes);  // Initialization the array codes
            InitialArrays.InitialAverageScore(arrayOfAverageScore);  // Initialization the array scores


            InitialArrays.InitialSerialNumberOfPassport(arrayOfSerialNumberPassport);  // Initialization the array serial number of passport
            InitialArrays.InitialNumberOfStudent(arrayNumberOfStudent);  // Initialization the array number of students


            InitialArrays.InitialArrayStudent(student, nameOfStudensMan, nameOfStudentsWoman, surnameOfStudentsMan, surnameofStudentsWoman, arrayIdentificationCodes,
                                              arrayOfAverageScore, arrayOfSerialNumberPassport, arrayNumberOfStudent);  // Initialization the array of sudents
            InitialArrays.InitialArrayGroup(group, student);  // Initialization the array of group
            InitialArrays.InitialArrayY(arrayPositionCursorY);  // Initialization cursor position by Y
            #endregion

            #region Scene 1
            //Console.Clear();  // Clear the console
            //PrintToConsole.PrintTheGrayTiles(spacebar);  // Print tiles all iver the console
            //PrintToConsole.ClearPlaceForText(spacebar);  // Clear part of place

            //PrintToConsole.PrintLogoApplication();  // Print logo
            //PrintToConsole.PrintTheList(counter);  // Print the list
            //PrintToConsole.DisplaySelectedOnTheScreen(counter);  // Choise start with first 

            //do  // Cycle of scene 1
            //{
            //    key = Console.ReadKey().Key;  // Initialization the value to users enter
            //    PrintToConsole.ClearBackgroundLine(counter);  // Clear old color line 
            //    UsersChoise.ChangeTheValueDependingOnUsersEntry(ref counter, key, ref usersSelectedValue);  // Changwe the value that knows which scene continue
            //    PrintToConsole.DisplaySelectedOnTheScreen(counter);  // Painting backboard of the line
            //} while ((key != ConsoleKey.Escape) && (usersSelectedValue == 0));  // Exit from cycle if the condition false
            //#endregion

            //#region Condition_For_Exit_1
            //if (usersSelectedValue == 5)  // If the condition true than exit from application 
            //{
            //    return;  // Exit from application
            //}
            //#endregion

            //#region List_Of_Students
            //if (usersSelectedValue == 1)  // If the condition is true
            //{
            //    Console.Clear();  // Clear the console
            //    PrintTheListOfStudents.FrameOnConsole(spacebar);  // Draw the frame on console
            //    PrintTheListOfStudents.LogoListOfStudents();  // Print the logo of scene 

            //    PrintTheListOfStudents.MainLineWithOption("|  №  |    Name    |    Surname   |");  // Print the main line 
            //    PrintTheListOfStudents.MainColumnWithOption(counterOfX, counterOfY);  // Print the main column

            //    PrintTheListOfStudents.ListOfStudents(student, counterOfX, counterOfY, counterOfBust);  // Print all list of students on console
            //    PrintTheListOfStudents.SelectedLineOfStudent(valueForExit, student, counterOfX, counterOfY);  // Print the selected line
            //    PrintTheListOfStudents.PrinTheColomnOfOptionStudent(counterOfX, counterOfY, valueForExit, student);  // Print the information of student

            //    do  // Cycle of scene
            //    {
            //        Console.SetCursorPosition(20, 20);  // Change coordinate that do not clear something
            //        key = Console.ReadKey().Key;  // Read the users enter

            //        PrintTheListOfStudents.NonSelectedLineOfStudent(valueForExit, student, counterOfX, counterOfY);  // Clear the background
            //        PrintTheListOfStudents.ClearTheColumn(counterOfX, counterOfY, spacebar);  // Clear the all information by column

            //        UsersChoise.UsersSelectedMove(ref valueForExit, key, ref counterOfY, student, usersSelectedValue);  // Compare users empty with our value
            //        PrintTheListOfStudents.PrinTheColomnOfOptionStudent(counterOfX, counterOfY, valueForExit, student);  // Print the information of students
            //        PrintTheListOfStudents.SelectedLineOfStudent(valueForExit, student, counterOfX, counterOfY);  // Print the selected line of student

            //        if (counterOfY >= 13)  // if the condition is true
            //        {
            //            counterOfY = 0;  // Nulled of the value
            //        }
            //    } while ((key != ConsoleKey.Escape) && (usersSelectedValue != 5));  // The condition for continue cycle
            //}
            #endregion

            //if (usersSelectedValue == 2)
            //{

            #region Users_Interface_Print
            AddTheStudent.FrameOnConsole(spacebar);
            AddTheStudent.LogoAddTheStudent();

            AddTheStudent.RequestTheUsersEnter("Name of student : ", arrayPositionCursorX[0], arrayPositionCursorY[0]);  // First line
            AddTheStudent.RequestTheUsersEnter("Surname of student : ", arrayPositionCursorX[0], arrayPositionCursorY[1]);  // Second line
            AddTheStudent.RequestTheUsersEnter("Gender(M/W) : ", arrayPositionCursorX[0], arrayPositionCursorY[2]);  // Third line

            AddTheStudent.RequestTheUsersEnter("Identification code(Ex. 123456789) : ", arrayPositionCursorX[0], arrayPositionCursorY[3]);  // Fourth line
            AddTheStudent.RequestTheUsersEnter("Average Score(from 60 to 100) : ", arrayPositionCursorX[0], arrayPositionCursorY[4]);  // Fifth line
            AddTheStudent.RequestTheUsersEnter("Serial number of student(KO901292) : ", arrayPositionCursorX[0], arrayPositionCursorY[5]);  // Sixth line

            AddTheStudent.RequestTheUsersEnter("Number of student(1234) : ", arrayPositionCursorX[0], arrayPositionCursorY[6]);  // Seventh line
            AddTheStudent.RequestTheUsersEnter("Number of group(From 1 to 3) : ", arrayPositionCursorX[0], arrayPositionCursorY[7]);  // Eight line
            AddTheStudent.RequestTheUsersEnter("Year of student(From 1 to 5) : ", arrayPositionCursorX[0], arrayPositionCursorY[8]);  // nineth line
            #endregion
            do
            {
                #region Users_Enter
                UsersChoise.AcceptUsersEnter(out name, arrayPositionCursorX[1], arrayPositionCursorY[0], ref key);  // Users enter
                if (key != ConsoleKey.Escape)
                {
                    UsersChoise.AcceptUsersEnter(out surname, arrayPositionCursorX[1], arrayPositionCursorY[1], ref key);  // Users enter
                    UsersChoise.AcceptUsersEnter(out gender, arrayPositionCursorX[1], arrayPositionCursorY[2]);  // Users enter

                    UsersChoise.AcceptUsersEnter(out identificationCode, arrayPositionCursorX[1], arrayPositionCursorY[3]);  // Users enter
                    UsersChoise.AcceptUsersEnter(out averageScore, arrayPositionCursorX[1], arrayPositionCursorY[4], ref key);  // Users enter
                    UsersChoise.AcceptUsersEnter(out serialNumberOfPassport, arrayPositionCursorX[1], arrayPositionCursorY[5], ref key);  // Users enter

                    UsersChoise.AcceptUsersEnter(out numberOfStudent, arrayPositionCursorX[1], arrayPositionCursorY[6]);  // Users enter
                    UsersChoise.AcceptUsersEnter(out numberOfGroup, arrayPositionCursorX[1], arrayPositionCursorY[7], ref key);  // Users enter
                    UsersChoise.AcceptUsersEnter(out year, arrayPositionCursorX[1], arrayPositionCursorY[8], ref key);  // Users enter
                    #endregion

                    BL_AddTheStudent.AddTheStudentInArray(student, ref numberElementInArray, name, surname, gender, identificationCode,
                                                          averageScore, serialNumberOfPassport, numberOfStudent, numberOfGroup, year);

                }
                AddTheStudent.RequestTheUsersEnter("Add another student(Press Enter)//////Exit(Press Escape) ", arrayPositionCursorX[1], arrayPositionCursorY[9]); 
                
                key = Console.ReadKey().Key;
                AddTheStudent.ClearTheUsersEnter(arrayPositionCursorX[1], arrayPositionCursorY);
            } while (key != ConsoleKey.Escape);
            //}
            




            Console.ReadKey();
        }
    }
}
