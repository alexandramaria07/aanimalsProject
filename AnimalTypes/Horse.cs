namespace animals.AnimalTypes
{
    public class Horse : Animal
    {
        private const string SOUND = "nihaaa-haaa";
        public Horse(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}