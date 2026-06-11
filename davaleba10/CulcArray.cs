using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba10
{
    //CulcArray კლასი აიმპლემენტირებს Iculc2 ინტერფეისს
    public class CulcArray : ICulc2
    {
        
        private int[] _numbers;
        //მასივი რომელზეც შესრულდება მეთოდები/მოქმედებები
        public CulcArray(int[] numbers)
        {
            _numbers = numbers;
        }

//მეთოდით ვთვლით რამდენი უნოკალური რიცხვია მასივში
//ვამოწმებთ თუ რიცხვი დუბლიკატი არაა ვზრდით ქაუნთს
        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < _numbers.Length; i++)
            { 
                bool isDublicate = false;

                for(int j = 0; j < i; j++)
                {
                    if (_numbers[i] == _numbers[j])
                    {
                        isDublicate = true;
                        break;
                    }
                }
                if(!isDublicate)
                {
                    count++;
                }
            }
            return count;

        }

        //ვიღებთ valueToCompareს და ვითვლით რამდენი გვაქვს მსგავსი რიცხვი და შემდეგ რაოდენობა გამოქგვაქვს
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int number in _numbers)
            {
                if (number == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
