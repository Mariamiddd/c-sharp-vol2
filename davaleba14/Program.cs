namespace davaleba14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Create an instance of our manager
            ScoreManager manager = new ScoreManager();

            while (true)
            {
                Console.WriteLine("\n--- მენიუ ---");
                Console.WriteLine("1 სტუდენტის დამატება");
                Console.WriteLine("2.სტუდენტის მოძებნა)");
                Console.WriteLine("3.ქულის განახლება");
                Console.WriteLine("4.ყველა სტუდენტის ჩვენება");
                Console.WriteLine("5.პროგრამიდან გამოსვლა");
                Console.Write("აირჩიე სასურველი ოპერაცია: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddStudent();
                        break;
                    case "2":
                        manager.SearchStudent();
                        break;
                    case "3":
                        manager.UpdateScore();
                        break;
                    case "4":
                        manager.ShowAllStudents();
                        break;
                    case "5":
                        Console.WriteLine("პროგრამიდან გამოსვლა...");
                        return;
                    default:
                        Console.WriteLine("incorect input. try again! ");
                        break;
                }
            }
        }
    }
}
