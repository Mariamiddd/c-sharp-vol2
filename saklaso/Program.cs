using System.IO;
namespace saklaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../data.txt";

            string[] lines = File.ReadAllLines(path);

            Student[] users = new Student[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                Console.WriteLine(parts[2]);
                users[i] = new Student();
                users[i].FirstName = parts[0];

                users[i].Age = int.Parse(parts[2]);
                users[i].Point = int.Parse(parts[5]);
            }

            #region davaleba1 
            //ვიპოვოთ ისეთი სტუდენტი რომელსაც აქვს ყველაზე დაბალი ქულა

            //ავტტომატურად ვაცხადებთ პირველ სტუდენტს ყველაზე დაბალქულიანად
            Student lowestPointStudent = users[0];

            for (int i = 1; i < users.Length; i++)
            {
                if (users[i].Point < lowestPointStudent.Point)
                {
                    lowestPointStudent = users[i];
                }
            }
            Console.WriteLine($"{lowestPointStudent.FirstName} has lowest score : {lowestPointStudent.Point}");


            #endregion


            #region davaleba 2
            //ვიპოვოთ ისეთი სტუდენტი რომელიც ყველაზე დიდია ასაკით

            Student oldestStudent = users[0];

            for (int i = 1; i < users.Length; i++)
            {
                if (users[i].Age > oldestStudent.Age)
                {
                    oldestStudent = users[i];
                }


            }
            Console.WriteLine($"{oldestStudent.FirstName} is oldest. Age : {oldestStudent.Age}");

            #endregion

            #region davaleba 3         
            //ვიპოვოთ ყველა სტუდენტის საშუალო ქულა
            //pirvelad udris 0 jami
            double total = 0;

            for (int i = 0; i < users.Length; i++)
            {
                total += users[i].Point; //emateba for loop is sashualebiT titoeuli jams 
            }
            double averagePoint = total / users.Length;
            Console.WriteLine($"average score of students is: {averagePoint}");

            #endregion

            #region  davaleba 4

            // დაასორტირეთ სტუდენტების მასივი
            //ასაკის მიხედვით დასორტირება
            //gare cikliT vakontrolebt ramdenjer gadauvlis shida masivs
            for (int i = 0; i < users.Length - 1; i++)
            {
                //gverdi gverd adarebs ricxvebs
                for (int j = 0; j < users.Length - 1 - i; j++)
                {
                    if (users[j] > users[j + 1])
                    {
                        Student temporarCvladi = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temporarCvladi;
                    }
                }
            }

            //გამოვიტანთ დასორტირებულ სიას
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"{users[i].FirstName} - Age: {users[i].Age}, Point: {users[i].Point}");
            }

            #endregion
        }

    }
}