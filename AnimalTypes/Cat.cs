namespace animals.AnimalTypes
{
    public class Cat : Animal
    {
        private const string SOUND = "meoow-meeooww";

        public Cat(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}