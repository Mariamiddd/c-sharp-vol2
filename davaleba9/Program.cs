namespace davaleba9
{
    internal class Program
    {
        static void Main(string[] args)
        #region Musical Instruments

        {
            Console.WriteLine("===================ukulele=======================");
            Ukulele myUkulele = new Ukulele();
            myUkulele.Sound();
            myUkulele.Show();
            myUkulele.Desc();
            myUkulele.History();
            Console.WriteLine("==========================================");


            Console.WriteLine("===================trombone=======================");
            Trombone myTrombone = new Trombone();
            myTrombone.Sound();
            myTrombone.Show();
            myTrombone.Desc();
            myTrombone.History();
            Console.WriteLine("==========================================");
        

        Console.WriteLine("===================Cello=======================");
            Cello myCello = new Cello();
            myCello.Sound();
            myCello.Show();
            myCello.Desc();
            myCello.History();
            Console.WriteLine("==========================================");


            Console.WriteLine("===================Violin=======================");
            Violin myViolin = new Violin();
            myViolin.Sound();
            myViolin.Show();
            myViolin.Desc();
            myViolin.History();
            Console.WriteLine("==========================================");

#endregion

        #region worker davaleba

            //worker davaleba

            President president = new President("Donald", 80);
            Security security = new Security("John", 30);
            Manager manager = new Manager("Alice", 35);
            Engineer engineer = new Engineer("Bob", 28);
            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
            #endregion
        }

    }
}
