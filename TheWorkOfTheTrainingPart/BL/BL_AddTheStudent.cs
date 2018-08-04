using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorkOfTheTrainingPart.Structs;

namespace TheWorkOfTheTrainingPart.BL
{
    class BL_AddTheStudent
    {
        public static void AddTheStudentInArray(Student[] students, ref int quntityOfStudents, string name, string surname, char gender, uint identificationCode, byte averageScore,
                                                string serialNumberOfPassport, uint numberOfStudent, byte numberOfGroup, byte year)  // Add the student in base
        {
            ++quntityOfStudents;  // Increment the value of quantity elements
            Array.Resize(ref students, quntityOfStudents);  // Change the size of array
            students[quntityOfStudents - 1].name = name;  // Add the information
            students[quntityOfStudents - 1].surname = surname;  // Add the information
            students[quntityOfStudents - 1].gender = gender;  // Add the information
            students[quntityOfStudents - 1].identificationCode = identificationCode;  // Add the information
            students[quntityOfStudents - 1].serialNumberOfPassport = serialNumberOfPassport;  // Add the information
            students[quntityOfStudents - 1].averageScore = averageScore;  // Add the information
            students[quntityOfStudents - 1].numberOfStudent = numberOfStudent;  // Add the information
            students[quntityOfStudents - 1].numberOfGroup = numberOfGroup;  // Add the information
            students[quntityOfStudents - 1].year = year;  // Add the information
        }
    }
}
