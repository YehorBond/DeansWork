using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorkOfTheTrainingPart.Structs;

namespace TheWorkOfTheTrainingPart.BL
{
    class InitialArrays
    {
        #region Main_Initialization
        #region Random_Value
        public static Random random = new Random();  // Random for initial arrays
        #endregion

        #region Initialization_Value_Of_Student
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayIdentificationcodes"></param>
        public static void InitialIdentificationCode(uint[] arrayIdentificationcodes)  // Initial array of identification code
        {
            for (int counterOfNumber = 0; counterOfNumber < arrayIdentificationcodes.Length; ++counterOfNumber)  // Cycle for notation value
            {
                arrayIdentificationcodes[counterOfNumber] = (uint)random.Next(100000000, 999999999);  // Notice the value in array
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayOfAverageScore"></param>
        public static void InitialAverageScore(byte[] arrayOfAverageScore)  // Initial array of average score
        {
            for (int counterOfNumber = 0; counterOfNumber < arrayOfAverageScore.Length; ++counterOfNumber)  // Cycle notation value
            {
                arrayOfAverageScore[counterOfNumber] = (byte)random.Next(60, 100);  // Notice value in array
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arraySerialNumberOfPassport"></param>
        public static void InitialSerialNumberOfPassport(string[] arraySerialNumberOfPassport)  // Initial array of Serial number 
        {
            for (int counterOfNumber = 0; counterOfNumber < arraySerialNumberOfPassport.Length; counterOfNumber++)  // Cycle notation value
            {
                string firstletter = Convert.ToString((char)random.Next('А', 'Я'));  // First letter
                string secondletter = Convert.ToString((char)random.Next('А', 'Я'));  // Second letter
                string numbers = Convert.ToString(random.Next(100000, 999999));  // Numbers
                string serialNumber = firstletter + secondletter + numbers;  // Decision of the value
                arraySerialNumberOfPassport[counterOfNumber] = serialNumber;  // Notice the value
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayNameOfStudent"></param>
        public static void InitialNumberOfStudent(uint[] arrayNameOfStudent)  // Initial array of number of student
        {
            for (int counterOfNumber = 0; counterOfNumber < arrayNameOfStudent.Length; ++counterOfNumber)  // Cycle notation values
            {
                arrayNameOfStudent[counterOfNumber] = (uint)random.Next(1000, 9999);  // Notice the value
            }
        }
        #endregion

        #region  Initialization_Array_Of_Students
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <param name="arrayNameOfStudentMan"></param>
        /// <param name="arrayNameOfStudentWoman"></param>
        /// <param name="arraySurnameOfStudentMan"></param>
        /// <param name="arraySurnameOfStudentWoman"></param>
        /// <param name="identificationCodes"></param>
        /// <param name="averageScores"></param>
        /// <param name="serialNumberOfPassports"></param>
        /// <param name="arrayNumberOfStudent"></param>
        public static void InitialArrayStudent(Student[] student, string[] arrayNameOfStudentMan, string[] arrayNameOfStudentWoman, string[] arraySurnameOfStudentMan,
                                               string[] arraySurnameOfStudentWoman, uint[] identificationCodes, byte[] averageScores, string[] serialNumberOfPassports,
                                               uint[] arrayNumberOfStudent)  // Initial array students values
        {
            byte counterOfNumber2 = 0;  // Variable of counter
            for (int counterOfNumber1 = 0; counterOfNumber1 < student.Length; counterOfNumber1++)  // Cycle notation value in array
            {
                if (counterOfNumber1 < (arrayNameOfStudentMan.Length))  // If value of counter less then lenght of array, carry out
                {
                    student[counterOfNumber1].name = arrayNameOfStudentMan[counterOfNumber1];
                    student[counterOfNumber1].surname = arraySurnameOfStudentMan[counterOfNumber1];
                    student[counterOfNumber1].gender = 'M';
                }
                else  // if value counter more
                {
                    student[counterOfNumber1].name = arrayNameOfStudentWoman[counterOfNumber2];  // Notice value
                    student[counterOfNumber1].surname = arraySurnameOfStudentWoman[counterOfNumber2];  // Notice value
                    student[counterOfNumber1].gender = 'W';  // Notice value
                    ++counterOfNumber2;  // Increment counter
                }
                student[counterOfNumber1].identificationCode = identificationCodes[counterOfNumber1];  // Notice value
                student[counterOfNumber1].averageScore = averageScores[counterOfNumber1];  // Notice value
                student[counterOfNumber1].serialNumberOfPassport = serialNumberOfPassports[counterOfNumber1];  // Notice value1];
                student[counterOfNumber1].numberOfStudent = arrayNumberOfStudent[counterOfNumber1];  // Notice value
                student[counterOfNumber1].year = (byte)random.Next(1, 3);  // Notice the value
                student[counterOfNumber1].numberOfGroup = (byte)random.Next(1, 6);  // Notice the value
            }
        }
        #endregion

        #region Initialization_Array_Of_Groups
        public static void InitialArrayGroup(Group[] groups, Student[] students)  // Initial array group the value by student
        {
            byte counterOfNumber2 = 0;  // The value of counter
            const byte quantityOfStudent = 11;  // The value quantity students in group
            byte endOfArray = quantityOfStudent;  // Finall bust in cycle
            for (int counterOfNumber1 = 0; counterOfNumber1 < groups.Length; ++counterOfNumber1)  // Cycle bust and notation value in group
            {
                groups[counterOfNumber1].student = new Student[quantityOfStudent];  // Initial quantity students in array
                for (int counterOfNumber3 = 0; counterOfNumber2 < endOfArray; ++counterOfNumber2, ++counterOfNumber3)  // Cycle bust and notation value in group
                {
                    groups[counterOfNumber1].student[counterOfNumber3] = students[counterOfNumber2];  // Notice the value

                }
                endOfArray = (byte)(counterOfNumber2 + quantityOfStudent);  // Change the value end of the cycle
            }
        }
        #endregion
        #endregion

        #region Initialization_Position_Y
        public static void InitialArrayY(byte[] arrayY)  // Initialization the array of position X
        {
            byte counterOfValueStart = (byte)(Console.LargestWindowHeight / 3);  // The first position by Y
            for (int counter = 0; counter < arrayY.Length; ++counter, counterOfValueStart += 2)  // Cycle bust the value
            {
                arrayY[counter] = counterOfValueStart;  // Notice the value
            }
        }
        #endregion
    }
}
