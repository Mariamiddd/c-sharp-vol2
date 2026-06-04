using System.Security.Cryptography.X509Certificates;

namespace davaleba8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ვინახავთ 8 ობიქტს Employ masivshi 
            Employ[] employs = new Employ[8];

            //employ კლასის ობიექტებს ვქმნი და ვავსებ მონაცემიტ 
            employs[0] = new Employ("Giorgi", "Alexidze", new DateTime(1998, 1, 21), Country.Georgia, Gender.Male, Contacts.mobile);
            employs[1] = new Employ("Nino", "Kapanadze", new DateTime(1998, 11, 23), Country.Georgia, Gender.Female, Contacts.mail);
            employs[2] = new Employ("John", "Doe", new DateTime(1990, 1, 15), Country.Greece, Gender.Male, Contacts.mail);
            employs[3] = new Employ("Sarah", "Smith", new DateTime(1993, 7, 4), Country.Italy, Gender.Female, Contacts.mobile);
            employs[4] = new Employ("Hans", "Müller", new DateTime(1985, 3, 30), Country.France, Gender.Male, Contacts.fax);
            employs[5] = new Employ("Anna", "Schmidt", new DateTime(1992, 9, 14), Country.France, Gender.Female, Contacts.mail);
            employs[6] = new Employ("Yuki", "Tanaka", new DateTime(2000, 12, 5), Country.Greece, Gender.Other, Contacts.mobile);
            employs[7] = new Employ("Ken", "Sato", new DateTime(1988, 8, 19), Country.Italy, Gender.Other, Contacts.mail);

            //employs qalaqis mixedvit
            Console.WriteLine("\nEmployees from France:");
            Employ.PrintByCountry(employs, Country.France);

            Console.WriteLine("\nEmployees from Georgia:");
            Employ.PrintByCountry(employs, Country.Georgia);

            Console.WriteLine("\nEmployees from Greece:");
            Employ.PrintByCountry(employs, Country.Greece);

            Console.WriteLine("\nEmployees from Italy:");
            Employ.PrintByCountry(employs, Country.Italy);


        }              
    }
}
