using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Student {
        public int ID;
        public string FirstName;
        public string LastName;
        public int? SAT;
        public double GPA;
        public int? MajorID;
        public Student(int id, string firstname, string lastname, int? sat, double gpa) {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            SAT = sat;
            GPA = gpa;
        }
        public void Printy() {
            Console.WriteLine($"Student ID - {ID}\nName - {FirstName} {LastName}\nSAT score - {SAT}\nGPA - {GPA}\n");
        }
    }
}