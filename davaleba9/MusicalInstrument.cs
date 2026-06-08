namespace davaleba9
{
    // ვქმნით base კლასს, რომელიც აბსტრაქტულია და ვქმნით სხვადასხვა ფაილებში 4 მუსიკალურ
    // ინსტრუმენტს, რომელსაც ვაძლევთ ამ კლასის მეთოდებს რომელზეც ოვერრაიდ არის შესაძლებელი
    internal abstract class MusicalInstrument
    {

        public string Name { get; set; }

        // კონსტრუქტორი, რომელიც იღებს ინსტრუმენტის სახელს
        public MusicalInstrument(string name)
        {
            Name = name;
        }

        // აბსტრაქტული მეთოდები რომლებსაც ოვერრაიდი ექნება მემკვიდრე კლასებში
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

    }


}
