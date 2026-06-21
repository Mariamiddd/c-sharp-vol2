using System;


namespace davaleba13
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            runMenu();
        }

        static void runMenu()
        {
            //ვქმნით 10 სტუდენტდს და ვნახავთ მასივში
            Student[] students = new Student[10];
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


            bool isWorking = true;
            while (isWorking)
            {

                Console.WriteLine("\n--- menu ---");
                Console.WriteLine("1.ყველა სტუდენტის ჩვენება");
                Console.WriteLine(" 2.საუკეთესო სტუდენტის პოვნა");
                Console.WriteLine("3.GPA - ის საშუალოს გამოთვლა");
                Console.WriteLine(" 4.სტუდენტის ძებნა გვარით");
                Console.WriteLine("5.სტუდენტების დალაგება GPA-ის მიხედვით");
                Console.WriteLine("6.ახალი სტუდენტის დამატება");
                Console.WriteLine("7.სტუდენტის წაშლა");
                Console.WriteLine("8.პროგრამიდან გასვლა");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    //1 პუნქტი: ყვველა სტუდენტის ჩვენება ფორ იჩით
                    case "1":
                        Console.WriteLine("1.ყველა სტუდენტის ჩვენება");

                        foreach (Student s in students)
                        {
                            if (s != null)
                            {
                                Console.WriteLine($"{s.Name} {s.LastName}, Age: {s.Age}, Faculty: {s.Faculty}, GPA: {s.GPA}");
                            }
                        }
                        break;
                    // პუნქტი 2: საუკეთესო gpa სტუდენტი
                    case "2":
                        Console.WriteLine("2.საუკეთესო სტუდენტi");
                        double bestGpa = -1;

                        foreach (Student s in students)
                        {
                            if (s != null && s.GPA > bestGpa)
                            {
                                bestGpa = s.GPA;
                            }
                        }

                        if (bestGpa != -1)
                        {
                            Console.WriteLine($"უმაღლესი ქულაა: {bestGpa}. ამ ქულის მფლობელები არიან:");
                            foreach (Student student in students)
                            {
                                if (student != null && student.GPA == bestGpa)
                                {
                                    Console.WriteLine($"- {student.Name} {student.LastName}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("სტუდენტების სია ცარიელია.");
                        }
                        break;

                    //პუნქტი 3: გპა საშუალო
                    case "3":
                        double totalGpaScore = 0;
                        int studentAmount = 0;

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null)
                            {
                                totalGpaScore += students[i].GPA;
                                studentAmount++;
                            }
                        }
                        if (studentAmount > 0) //vamowmebT rom nulze gayofa ar moxdes
                        {
                            double averageGpa = totalGpaScore / studentAmount;
                            Console.WriteLine($"students average score is: {Math.Round(averageGpa, 3)}");
                        }
                        break;
                    //პუნქტი 4: გვარითს სტუდენტის მოძებნა
                    case "4":
                        Console.Write("enter lastName:");
                        //momxmareblis sheyvanili gvari
                        string searchedLastname = Console.ReadLine();
                        string formattedInput = searchedLastname.Trim().ToLower();

                        bool isFound = false;
                        foreach (Student s in students)
                        {
                            if (s != null)
                            {
                                string studentLastName = s.LastName.ToLower();
                                if (studentLastName.Contains(formattedInput))
                                {
                                    Console.WriteLine($"founded: {s.Name} {s.LastName}, Age: {s.Age}, Faculty: {s.Faculty}, GPA: {s.GPA}");
                                    isFound = true;
                                }
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("student with that lastname doesnt exist");
                        }
                        break;

                    //პუნქტი 5: gpa ქულების მიხედვით დალაგება

                    case "5":
                        //bubble sort
                        for (int i = 0; i < students.Length - 1; i++)
                        {
                            for (int j = 0; j < students.Length - 1 - i; j++)
                            {
                                if (students[j] != null && students[j + 1] != null)
                                {
                                    if (students[j].GPA < students[j + 1].GPA)
                                    {
                                        Student temp = students[j];
                                        students[j] = students[j + 1];
                                        students[j + 1] = temp;
                                    }
                                }
                                else if (students[j] == null && students[j + 1] != null)
                                {
                                    Student temp = students[j];
                                    students[j] = students[j + 1];
                                    students[j + 1] = temp;
                                }
                            }
                        }
                        foreach (Student s in students)
                        {
                            if (s != null)
                            {
                                Console.WriteLine($"{s.Name} {s.LastName} | GPA: {s.GPA}");
                            }
                        }
                        break;
                    //პუნქტი 6: სტუდენტის დამატება
                    case "6":
                        try
                        {
                            Console.Write("Enter NAme: ");
                            string newName = Console.ReadLine();

                            Console.Write("enter lastname: ");
                            string newlastName = Console.ReadLine();

                            Console.Write("enter age(minimal age should be 17):");
                            int newAge = byte.Parse(Console.ReadLine());
                            if (newAge < 17)
                            {
                                Console.WriteLine("Student should be older than 16 yars old!");
                                break;
                            }
                            Console.Write("enter Email");
                            string newEmail = Console.ReadLine();
                            if (!newEmail.Contains("@"))
                            {
                                Console.WriteLine("try again! email should consist @!");
                                break;
                            }

                            Console.Write("Enter phone  number:");
                            string newPhone = Console.ReadLine();

                            Console.Write("enter gpa(0-100 diapazonshi):");
                            double newGpa = double.Parse(Console.ReadLine());
                            if (newGpa < 0 || newGpa > 100)
                            {
                                Console.WriteLine("try again: gpa should be 0-100!");
                                break;
                            }

                            Console.Write("choose faculty (0: IT, 1: Business, 2: Design, 3: Medicine):");
                            int facultyChoice = int.Parse(Console.ReadLine());
                            Faculty newFaculty = (Faculty)facultyChoice;

                            //vzrdit masivs 1it
                            Array.Resize(ref students, students.Length + 1);

                            students[students.Length - 1] = new Student(newName, newlastName, (byte)newAge, newEmail, newPhone, newGpa, newFaculty);
                            Console.WriteLine("ახალი სტუდენტი წარმატებით დაემატა!");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("შეცდომა: გთხოვთ შეიყვანოთ სწორი ფორმატის მონაცემები (მაგ: ასაკი და GPA უნდა იყოს რიცხვი)!");
                        }
                        break;

                    case "7":
                        Console.Write("Enter Email to delete the student: ");
                        string inputEmail = Console.ReadLine().Trim().ToLower();
                        bool isStudentDeleted = false;

                        //vamowmebt for loop it titoeul students

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i] != null && students[i].Email.ToLower() == inputEmail)
                            {
                                Console.WriteLine($"Student {students[i].Name} {students[i].LastName} has been deleted.");
                                students[i] = null;
                                isStudentDeleted = true;
                                break;
                            }
                        }
                        if (!isStudentDeleted)
                        {
                            Console.WriteLine("student with this mail not found!");
                        }
                        break;


                    // პროგრამიდან გასვლა როდესაც bool ვანიჭებთ false მნიშვნელობას
                    case "8":
                        Console.WriteLine("პროგრამა დასრულდა.");
                        isWorking = false; // გამოვდივართ პროგრამიდან
                        break;

                    default:
                        //არასწორი ღილაკის დაჭერის შემთხვევაში მენიუს თავიდან ვბეჭდავთ

                        Console.WriteLine("არასწორი არჩევანი. გთხოვთ შეიყვანოთ სწორი რიცხვი.");
                        break;
                }
            }
        }
 

    }
}