using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace saklaso
{
    internal class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Point { get; set; }


        //ოპერატორის გადატვირთვა >ზე
        public static bool operator >(Student s1, Student s2)
        {
            return s1.Age > s2.Age;
        }

        // გადატვირთვა < ოპერატორზე
        public static bool operator <(Student s1, Student s2)
        {
            return s1.Age < s2.Age;
        }

        //ოპერატორების გადათვირთვა +
        public static  double operator + (Student s1, Student s2)
        {
            return s1.Point * s2.Point;
        }

        // gadatvirtva / gayofaze
        public static double operator /(Student s, int raodenoba)
        {
            return (double)s.Point / raodenoba;
        }



        //ვიპოვოთ ისეთი სტუდენტი რომელსაც აქვს ყველაზე დაბალი ქულა
        //ვიპოვოთ ისეთი სტუდენტი რომელიც ყველაზე დიდია ასაკით
        //ვიპოვოთ ყველა სტუდენტის საშუალო ქულა
        // დაასორტირეთ სტუდენტების მასივი
    }
}