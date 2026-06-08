namespace davaleba9
{
    //ვქმნით აბსტრაქტულ კლასს, მასში ვსაზღვრავთ საერთო თვისებებბს და პრინტ მეთოდს
    internal abstract class Worker
    {
        public String Name { get; set; }

        public String Occupation { get; set; }

        public int Age { get; set; }

        public Worker(string name, string occupation, int age)
        {
            Name = name;
            Occupation = occupation;
            Age = age;
        }

        public abstract void Print();
    }

    //ვქმნით 4 კლასს რომლებიც მემკვიდრრეები არიან worker კლასის და ოვერრაიდს ვუკეთებთ პრინტ მეთოდს
    internal class President : Worker
    {
        public President(string name, int age) : base(name, "President", age)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Occupation: {Occupation}, Age: {Age}");
        }

        
    }

    internal class Security : Worker
    {
        public Security(string name, int age) : base(name, "Security", age)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Occupation: {Occupation}, Age: {Age}");
        }
    }

    internal class Manager : Worker
    {
        public Manager(string name, int age) : base(name, "Manager", age)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Occupation: {Occupation}, Age: {Age}");
        }
    }

    internal class Engineer : Worker
    {
        public Engineer(string name, int age) : base(name, "Engineer", age)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Occupation: {Occupation}, Age: {Age}");
        }
    }

}
