using System;
namespace davaleba8
{
    // creating employ class 
    public class Employ
    {
        // creating properties of employ class
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }

        // properties from enum class
        public Country Country { get; set; }
        public Gender Gender { get; set; }
        public Contacts Contacts { get; set; }
    

    // პარამეტრიანი კონსტრუქტორი, რომელიც ყველა თვისებას იღებს
    public Employ(string name, string surname, DateTime dateofbirth, Country country, Gender gender, Contacts contacts)
        {
            Name = name;
            Surname = surname;
            DateofBirth = dateofbirth;
            Country = country;
            Gender = gender;
            Contacts = contacts;

        }

        // მეთოდი რომელიც გამოთვლის ასაკს დდაბადების თარიღიდან
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - DateofBirth.Year;

            //თუ დაბადების დღე ჯერ არ ჰქონია ვაკლებთ -1 წელს 
            if (DateofBirth.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }

}