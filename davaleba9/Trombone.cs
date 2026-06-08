namespace davaleba9
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone")
        { 
        }
        public override void Sound()
        {
            Console.WriteLine("Trombone produces a rich and powerful sound.");
        }
        public override void Show()
        {
            Console.WriteLine($"instrument name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("The trombone is a brass instrument that consists of a long cylindrical tube with a flared bell at the end. It is played by buzzing the lips into a mouthpiece and using a slide to change the pitch. The trombone is known for its rich and powerful sound, and it is commonly used in various musical genres, including classical, jazz, and marching bands.");
        }
        public override void History()
        {
            Console.WriteLine("The trombone has a long history dating back to the 15th century. It evolved from the earlier instrument called the sackbut, which was used in Renaissance music. The trombone underwent various modifications over the centuries, leading to the modern design we see today. It has been a staple in orchestras and bands for centuries and continues to be an essential instrument in many musical styles.");
        }

    }
}
