using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace davaleba13
{
    public class Student : Person, IPrintable
    {
        //student class with properties

        public double GPA { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string name, string lastName, byte age, string email, string phone, double gpa, Faculty faculty)
          : base(name, lastName, age, email, phone)
        {
            GPA = gpa;
            Faculty = faculty;
        }


            // ინტერფეისის მეთოდის იმპლემენტაცია
        public void Print()
        {
            Console.WriteLine($"{Name} {LastName} | Age: {Age} | Faculty: {Faculty} | GPA: {GPA}");
        }
        //operatorebis gadatvirtva
        public static bool operator >(Student s1, Student s2) => s1.GPA > s2.GPA;
        public static bool operator <(Student s1, Student s2) => s1.GPA < s2.GPA;
    }

    }
