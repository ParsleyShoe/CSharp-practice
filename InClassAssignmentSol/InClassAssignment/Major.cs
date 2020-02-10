using System;
using System.Collections.Generic;
using System.Text;

namespace InClassAssignment {
    class Major {
        public int Id;
        public string Description;
        public int MinSat;
        public Major(int id, string descr, int minsat) {
            Id = id;
            Description = descr;
            MinSat = minsat;
        }
        public void Print() {
            Console.WriteLine($"Major ID:\t\t{Id}\nDescription of Major:\t{Description}\nMinimum SAT score:\t{MinSat}\n");
        }
    }
    class MajorClassRel {
        public int Id;
        public int MajorId;
        public int ClassId;
        public MajorClassRel(int a, int b, int c) {
            Id = a;
            MajorId = b;
            ClassId = c;
        }
    }
    class Class {
        public int Id;
        public string Subject;
        public int Section;
        public int InstructorId;
        public Class(int a, string b, int c, int d) {
            Id = a;
            Subject = b;
            Section = c;
            InstructorId = d;
        }
    }
    class Student {
        public int Id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public double GPA;
        public Major Major;
        public Student(int a, string b, string c, int d, double e, Major f) {
            Id = a;
            Firstname = b;
            Lastname = c;
            SAT = d;
            GPA = e;
            Major = f;
        }
        public void Print() {
            Console.WriteLine($"Name:\t\t{Firstname} {Lastname}\nSAT score:\t{SAT}\nGPA:\t\t{GPA}\nMajor:\t\t{Major.Description}\n");
        }
    }
    class Instructor {
        public int Id;
        public string Firstname;
        public string Lastname;
        public int YearsExperience;
        public bool IsTenured;
        public Instructor(int a, string b, string c, int d, bool e) {
            Id = a;
            Firstname = b;
            Lastname = c;
            YearsExperience = d;
            IsTenured = e;
        }
    }
    class StudentClassRel {
        public int Id;
        public int StudentId;
        public int ClassId;
        public int ClassGradeValue;
        public StudentClassRel(int a, int b, int c, int d) {
            Id = a;
            StudentId = b;
            ClassId = c;
            ClassGradeValue = d;
        }
    }
    // add more classes (Assignment [id, description, class id], Class grade [grade, gpa])
}