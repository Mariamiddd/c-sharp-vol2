using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba9
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Violin")
        {
        }
        public override void Sound()
        {
            Console.WriteLine("The violin produces a bright and expressive sound.");
        }
        public override void Show()
        {
            Console.WriteLine($"instrument name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("The violin is a string instrument that belongs to the violin family. It is the smallest and highest-pitched member of the family. The violin is played by drawing a bow across its strings or plucking them with the fingers. It is known for its bright and expressive sound, and it is commonly used in classical music, folk music, and various other genres.");
        }
        public override void History()
        {
            Console.WriteLine("The violin has a long history dating back to the 16th century. It evolved from earlier string instruments such as the medieval fiddle and the Renaissance lira da braccio. The violin quickly gained popularity in Europe and became a central instrument in classical music. It has been used by many renowned composers and continues to be an essential instrument in orchestras, chamber music, and solo performances.");
        }
        
    }
}
