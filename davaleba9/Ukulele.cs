using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba9
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Ukulele produces a bright and cheerful sound.");
        }
        public override void Show()
        {
            Console.WriteLine($"instrument name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("The ukulele is a small, guitar-like instrument that originated in Hawaii. It typically has four nylon strings and is known for its bright and cheerful sound. The ukulele is often associated with Hawaiian music and is popular for its portability and ease of play.");
        }
        public override void History()
        {
            Console.WriteLine("The ukulele was developed in the 19th century in Hawaii, influenced by Portuguese instruments such as the machete. It quickly became popular in Hawaiian music and later gained international recognition, especially during the early 20th century. The ukulele has since become a beloved instrument worldwide, known for its distinctive sound and versatility.");
        }
    }
}
