using System;
namespace davaleba8
{
    // creating employ class 
    public class Employ
    {
        // creating properties of employ class
        //ვქმნით private fields და მათზე სრული პროფერთები, რათა შევამოწმოთ მონაცემები და დავრწმუნდეთ რომ ისინი სწორია
        private string _name;
        private string _surname;
        private DateTime _dateofbirth;
        public string Name
        {
            //sruli property saxelistvis
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("სახელი არ შეიძლება იყოს ცარიელი!");

           
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("სახელი არ უნდა შეიცავდეს ციფრებს!");

                _name = value; // Tu sworia vinaxavT
            }
        }
        //sruli property gvaristvis
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("გვარი არ შეიძლება იყოს ცარიელი!");

                if (value.Any(char.IsDigit))
                    throw new ArgumentException("გვარი არ უნდა შეიცავდეს ციფრებს!");

                _surname = value;
            }
        }
        // sruli property dabadebis tarigis
        public DateTime DateofBirth
        {
            get { return _dateofbirth; }
            set
            {
                // თარიღი არ უნდა იყოს მომავალში
                if (value > DateTime.Today)
                    throw new ArgumentException("დაბადების თარიღი არ შეიძლება იყოს მომავალში!");

                _dateofbirth = value;
            }
        }

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


        // ვფილტრავთ ქვეყნის კონკრეტული ქვეყნის მიხედვტ და ვბეჭდავთ პიროვნებას
        public static void PrintByCountry(Employ[] array, Country originCountry)
        {
            foreach (Employ emp in array)
            {
                // ვამოწმებთ ქვეყანა ემთხვევა თუ არა თანამშრომლის ქვეყანას 
                if (emp.Country == originCountry)
                {
                    //ვბეჭდავთ იმ თანამშრომლებს როლებიც აეიან იმ ქვეყნიდან და ვიყენებთ

                    Console.WriteLine($"Name: {emp.Name} {emp.Surname}, Age: {emp.CalculateAge()}, Country: {emp.Country}");
                }
            }
        }
    }

}