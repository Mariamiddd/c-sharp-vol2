using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace davaleba13
{
    #region 1პუნქტი
    public class Student
    {
        //student class with properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double GPA { get; set; }
        public Faculty Faculty { get; set; }

        //კონსტრუქტორი მოგვიანებით ობიქტების შესაქმნელად

        public Student(string name, string lastName, byte age, string email, string phone, double gpa, Faculty faculty)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
            GPA = gpa;
            Faculty = faculty;


        }
    #endregion

    }
}
