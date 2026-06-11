namespace davaleba10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // რიცხვების მასივი
            int[] testNumbers = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 2, 1, 4, 6, 2, 8, 9, 10 };

            #region dabaleba 1

            //ვქმნით ArrayOfNums კლასის ობიექტს 
            ArrayOfNums myArray = new ArrayOfNums(testNumbers);

            Console.WriteLine("---------------------davaleba1-----------------------");
            // ვიძახებთ Odd და Even მეთოდებს, რომლებიც გამოიტანენ შესაბამის რიცხვებს
            myArray.ShowOdd();
            myArray.ShowEven();

            Console.WriteLine("------------------------------------------------------");

            #endregion

            #region davaleba2

            Console.WriteLine("------------------davaleba2--------------------");

            //ვქმნით myCulcArray ობიექტს
            CulcArray myCulcArray = new CulcArray(testNumbers);
            //ვიძახებთ CountDistinct მეთოდს,რომელიც გამოიტანს უნიკალური რიცხვების რაოდენობას
            int uniqueCount = myCulcArray.CountDistinct();
            Console.WriteLine($"Unique numbers count: {uniqueCount}");
            //ვიძახებთ EqualToValue მეთოდს რომელიც გამოიტანს რიცხვების რაოდენობას რომელიც ტოლი იქნებ ა2ის
            int countOfValue = myCulcArray.EqualToValue(2);
            Console.WriteLine($"Count of numbers equal to 2: {countOfValue}");
            Console.WriteLine("--------------------------------------------------");

            #endregion

        }
    }
}
