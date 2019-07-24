namespace animals.AnimalTypes
{
    public class Pig : Animal, IMakeSound
    {
        private const string SOUND = "groh-grohh";

        public Pig(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}