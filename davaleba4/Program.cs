using System;
using System.Globalization;
namespace davaleba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region davaleba 1
            int[] arrayOne = [1, 2, 3];
            int[] arrayTwo = [4, 5, 6];

            //joining 2 arrays length
            int[] joinedArr = new int[arrayOne.Length + arrayTwo.Length];

            //fill joinedarr with array oone
            for (int i = 0; i < arrayOne.Length; i++)
            {

                joinedArr[i] = arrayOne[i];

            }
            //filling joinedarr with second arr
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                joinedArr[i + arrayOne.Length] = arrayTwo[i];


            }

            //printing joined array together
            for (int i = 0; i < joinedArr.Length; i++)
            {

                Console.Write(joinedArr[i] + ", ");
            }

            #endregion

            #region davaleba 2
            int[] arrayNums = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 7;

            int pairCount = 0;
            for (int i = 0; i < arrayNums.Length; i++)
            {
                for (int j = i + 1; j < arrayNums.Length; j++)
                {
                    if (arrayNums[j] + arrayNums[i] == targetSum)
                    {
                        pairCount++;
                    }
                }
            }
            if (pairCount == 0)
            {
                Console.WriteLine("wyvili ar moidzebna");
            }
            else
            {
                int[,] resultArray = new int[pairCount, 2];

                int currentRow = 0;

                for (int i = 0; i < arrayNums.Length; i++)
                {
                    for (int j = i + 1; j < arrayNums.Length; j++)
                    {
                        if (arrayNums[j] + arrayNums[i] == targetSum)
                        {
                            //first num in first column
                            resultArray[currentRow, 0] = arrayNums[i];

                            //second in second one

                            resultArray[currentRow, 1] = arrayNums[j];
                            //shemdeg rowze gadasvla
                            currentRow++;
                        }
                    }
                }
            
            Console.Write("resultArray = [ ");

            //gadavuvli paircounts rom davbechdot wyvilebi 
            for (int i = 0; i < pairCount; i++)
            {
                //rig i-ze vbeWdavt pirvel da meore wevrs
                Console.Write("[" + resultArray[i, 0] + ", " + resultArray[i, 1] + "]");

                // vsvamt mdzimes bolo adgilis garda 
                if (i < pairCount - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(" ]");

        }

            #endregion
        }
    }
}
