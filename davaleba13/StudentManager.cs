using System;

namespace davaleba13
{
    public class StudentManager
    {
        private Student[] students;

        //ვქმნით 10 სტუდენტდს და ვნახავთ მასივში
        public StudentManager()
        {
            students = new Student[10];
            students[0] = new Student("giorgi", "nadibaidze", 20, "giorginadibaidze@gmail.com", "55555555555", 2.3, Faculty.IT);
            students[1] = new Student("ana", "beridze", 19, "ana.beridze@example.com", "5959595959", 3.1, Faculty.Business);
            students[2] = new Student("nino", "zhvania", 22, "nino.zhvania@example.com", "5777777777", 3.8, Faculty.Design);
            students[3] = new Student("lasha", "kapanadze", 21, "lasha.kapanadze@example.com", "5912345678", 2.9, Faculty.IT);
            students[4] = new Student("ketevan", "chinua", 23, "ketevan.chinua@example.com", "5987654321", 3.6, Faculty.Medicine);
            students[5] = new Student("giorgi", "bolkvadze", 20, "g.bolkvadze@example.com", "5551234567", 2.7, Faculty.Business);
            students[6] = new Student("mari", "giorgadze", 18, "mari.giorgadze@example.com", "5544444444", 4.0, Faculty.Design);
            students[7] = new Student("aleksei", "ivanov", 24, "aleksei.ivanov@example.com", "5533333333", 3.2, Faculty.Medicine);
            students[8] = new Student("sopo", "tsereteli", 20, "sopo.tsereteli@example.com", "5522222222", 3.0, Faculty.IT);
            students[9] = new Student("dato", "smith", 21, "dato.smith@example.com", "5511111111", 4.0, Faculty.Business);
        }

        //მთავარი მეთოდი საიდანაც მენიუ ეშვება
        public void RunMenu()
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("\n--- menu ---");
                Console.WriteLine("1.ყველა სტუდენტის ჩვენება");
                Console.WriteLine("2.საუკეთესო სტუდენტის პოვნა");
                Console.WriteLine("3.GPA - ის საშუალოს გამოთვლა");
                Console.WriteLine("4.სტუდენტის ძებნა გვარით");
                Console.WriteLine("5.სტუდენტების დალაგება GPA-ის მიხედვით");
                Console.WriteLine("6.ახალი სტუდენტის დამატება");
                Console.WriteLine("7.სტუდენტის წაშლა");
                Console.WriteLine("8.პროგრამიდან გასვლა");

                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        ShowAllStudents();
                        break;
                    case "2":
                        FindBestStudent();
                        break;
                    case "3":
                        CalculateAverageGpa();
                        break;
                    case "4":
                        SearchByLastName();
                        break;
                    case "5":
                        SortByGpa();
                        break;
                    case "6":
                        AddStudent();
                        break;
                    case "7":
                        DeleteStudent();
                        break;
                    case "8":
                        Console.WriteLine("პროგრამა დასრულდა.");
                        isWorking = false; //გამოვდივართ პროგრამიდან
                        break;
                    default:
                        Console.WriteLine("არასწორი არჩევანი. გთხოვთ შეიყვანოთ სწორი რიცხვი.");
                        break;
                }
            }
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("1.ყველა სტუდენტის ჩვენება");
            foreach (var s in students)
            {
                if (s != null) Console.WriteLine($"{s.Name} {s.LastName}, Age: {s.Age}, Faculty: {s.Faculty}, GPA: {s.GPA}");
            }
        }

        public void FindBestStudent()
        {
            Console.WriteLine("2.საუკეთესო სტუდენტi");
            double bestGpa = -1;
            foreach (var s in students)
            {
                if (s != null && s.GPA > bestGpa) bestGpa = s.GPA;
            }
            if (bestGpa != -1)
            {
                Console.WriteLine($"უმაღლესი ქულაა: {bestGpa}. ამ ქულის მფლობელები არიან:");
                foreach (var s in students)
                {
                    if (s != null && s.GPA == bestGpa) Console.WriteLine($"- {s.Name} {s.LastName}");
                }
            }
            else
            {
                Console.WriteLine("სტუდენტების სია ცარიელია.");
            }
        }

        public void CalculateAverageGpa()
        {
            double total = 0; int count = 0;
            foreach (var s in students)
            {
                if (s != null) { total += s.GPA; count++; }
            }
            if (count > 0) Console.WriteLine($"students average score is: {Math.Round(total / count, 3)}");
        }

        public void SearchByLastName()
        {
            Console.Write("enter lastName:");
            string searchedLastname = Console.ReadLine();
            string formattedInput = searchedLastname.Trim().ToLower();
            bool isFound = false;
            foreach (Student s in students)
            {
                if (s != null)
                {
                    if (s.LastName.ToLower().Contains(formattedInput))
                    {
                        Console.WriteLine($"founded: {s.Name} {s.LastName}, Age: {s.Age}, Faculty: {s.Faculty}, GPA: {s.GPA}");
                        isFound = true;
                    }
                }
            }
            if (!isFound) Console.WriteLine("student with that lastname doesnt exist");
        }

        public void SortByGpa()
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - 1 - i; j++)
                {
                    if (students[j] != null && students[j + 1] != null)
                    {
                        if (students[j].GPA < students[j + 1].GPA)
                        {
                            var tmp = students[j]; students[j] = students[j + 1]; students[j + 1] = tmp;
                        }
                    }
                    else if (students[j] == null && students[j + 1] != null)
                    {
                        var tmp = students[j]; students[j] = students[j + 1]; students[j + 1] = tmp;
                    }
                }
            }
            foreach (var s in students) if (s != null) Console.WriteLine($"{s.Name} {s.LastName} | GPA: {s.GPA}");
        }

        public void AddStudent()
        {
            try
            {
                Console.Write("Enter NAme: ");
                string newName = Console.ReadLine();
                Console.Write("enter lastname: ");
                string newlastName = Console.ReadLine();
                Console.Write("enter age(minimal age should be 17):");
                int newAge = byte.Parse(Console.ReadLine());
                if (newAge < 17) { Console.WriteLine("Student should be older than 16 yars old!"); return; }
                Console.Write("enter Email");
                string newEmail = Console.ReadLine();
                if (!newEmail.Contains("@")) { Console.WriteLine("try again! email should consist @!"); return; }
                Console.Write("Enter phone  number:");
                string newPhone = Console.ReadLine();
                Console.Write("enter gpa(0-100 diapazonshi):");
                double newGpa = double.Parse(Console.ReadLine());
                if (newGpa < 0 || newGpa > 100) { Console.WriteLine("try again: gpa should be 0-100!"); return; }
                Console.Write("choose faculty (0: IT, 1: Business, 2: Design, 3: Medicine):");
                int facultyChoice = int.Parse(Console.ReadLine());
                Faculty newFaculty = (Faculty)facultyChoice;
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = new Student(newName, newlastName, (byte)newAge, newEmail, newPhone, newGpa, newFaculty);
                Console.WriteLine("ახალი სტუდენტი წარმატებით დაემატა!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ერორი! ასაკი და gpa უნდა იყოს რიცხვი. შეიყვანე მონაცემები სწორად@ ");
            }
        }

        public void DeleteStudent()
        {
            Console.Write("ეnter mail to delete the student: ");
            string inputEmail = Console.ReadLine().Trim().ToLower();
            bool isStudentDeleted = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].Email.ToLower() == inputEmail)
                {
                    Console.WriteLine($"Student {students[i].Name} {students[i].LastName} has been deleted");
                    students[i] = null;
                    isStudentDeleted = true;
                    break;
                }
            }
            if (!isStudentDeleted) Console.WriteLine("student with this mail not found!");
        }
    }
}
