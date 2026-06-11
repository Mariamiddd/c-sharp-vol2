using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba10
{
    // ამ ინტერფეისში ვაცხადებთ ორ მეთოდს, რომელსაც მიიღებს ამ ინტერფეისის კლასები 
    public interface ICulc2
    {

         int CountDistinct();
         int EqualToValue(int valueToCompare);
    }
}
