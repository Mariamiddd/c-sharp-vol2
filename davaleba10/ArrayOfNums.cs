using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba10
{
    //ArrayOfNums აიმპლემენტირებს IOutPut2 ინტერფეისს
    public class ArrayOfNums : IOutput2
    {
        private int[] _numbers;

        //მასივი რომელზეც მოხდება მოქმედებები
        public ArrayOfNums(int[] numbers)
        {
            _numbers = numbers;
        }

        //გამოაქვს ლუწი რიცხვები
        public void ShowEven()
        {
            Console.WriteLine("Even numbers:");
            foreach (int number in _numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }


        //კენტი რიცხვები გამოაქვს ამ მეთოდს
        public void ShowOdd()
        {
            Console.WriteLine("Odd Numbers:");
            foreach (int number in _numbers)
            {
                if (number % 2 == 1)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
