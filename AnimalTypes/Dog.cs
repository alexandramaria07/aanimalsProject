namespace animals.AnimalTypes
{
    public class Dog : Animal
    {
        private const string SOUND = "woff-wofff-wofff";

        public Dog(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}