using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace davaleba15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testing filter algorithm
            List<int> numbers = new List<int> { 1, 2, 567, -123, -1,5, -32, 7843, 32, 64 };

            // using filter on the num list
            IEnumerable<int> positiveNums = numbers.Filter(n => n > 0);

            Console.WriteLine("1. Numbers > 0 are:");
            foreach (int i in positiveNums)
            {
                Console.WriteLine(i);
            }

            //2 ordered
            Console.WriteLine("2. ordered list: ");
            IEnumerable<int> orderedList = numbers.OrderedData(n => n);
            foreach(int i in orderedList)
                {  Console.WriteLine(i); }

            //3 first
            Console.WriteLine("3. first element of the list:");
            int first = numbers.FirstElement();
            Console.WriteLine(first);

            // 4 first or default 
            Console.WriteLine("4. first or default:");
            List<int> firstorD = new List<int> {  };
            int firstElD = firstorD.FirstElement();
            //with empty list
            Console.WriteLine(firstElD);
            int firstEl = numbers.FirstElement();
            //with list with members/nums
            Console.WriteLine(firstEl);

            //5 Single
            Console.WriteLine("5. single or default:");
            int single = numbers.CustomSingle(n => n == 5);
            Console.WriteLine(single); 

            //6. SingleOrDefault
            Console.WriteLine("6. single or default:");
            int SingleOrDefault = numbers.SingleOrDefault(n => n == 6);
            Console.WriteLine(SingleOrDefault);

            //7. custum any
            Console.WriteLine("7. ANY");
            bool hasNum = numbers.CustomAny(n => n == 5);
            Console.WriteLine(hasNum);

            //8.ALL
            Console.WriteLine("8. ALL");
            bool IsAllTrue = numbers.CustomAll(n => n > 0);
            Console.WriteLine(IsAllTrue);

            //9. count
            Console.WriteLine("9. customcount");
            int CountTotal = numbers.CustomCount(n => n < 0);
            Console.WriteLine(CountTotal);

            //10.distinct
            Console.WriteLine("10. distinct");
            IEnumerable<int> noDuplicates = numbers.CustomDistinct();

            foreach (int i in noDuplicates)
            {
                Console.WriteLine(i);
            }
        }
    }
}

