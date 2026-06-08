namespace davaleba9
{
    internal class Cello : MusicalInstrument
    {
        public Cello() : base("Cello")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The cello produces a deep and rich sound.");
        }
        public override void Show()
        {
            Console.WriteLine($"instrument name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine("The cello is a string instrument that belongs to the violin family. It is larger than a violin and viola, and it is played by drawing a bow across its strings or plucking them with the fingers. The cello is known for its deep and rich sound, and it is commonly used in classical music, chamber music, and orchestras.");
        }
        public override void History()
        {
            Console.WriteLine("The cello has a long history dating back to the 16th century. It evolved from earlier string instruments such as the viola da gamba. The cello became popular in the Baroque period and has since been a staple in classical music. It has been used by many renowned composers and continues to be an essential instrument in orchestras and chamber music ensembles.");
        }
    }
}
