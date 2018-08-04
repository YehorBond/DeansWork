using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorkOfTheTrainingPart.Structs
{
    public struct Student  // Structure of student which  studying in academy
    {
        public string name;  // Name of student
        public string surname;  // Surname of student 

        public char gender;  // Gender of the student of academy
        public uint identificationCode;  // Identification code include by ten numbers

        public byte averageScore;  // System of score from 60 to 100
        public string serialNumberOfPassport;  // Serial number contents numbers and letters 
        public uint numberOfStudent;  // Student has number in academy, it is four numbers

        public byte numberOfGroup;  // The number of the group in academy
        public byte year;  // Number of year by group
    }
}
