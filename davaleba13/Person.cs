using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba13
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public  string Email { get; set; }
        public string Phone { get; set; }
        protected Person(string name, string lastName, byte age, string email, string phone)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
        }
    }
}
