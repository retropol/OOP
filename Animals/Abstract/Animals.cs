using OOP.Environments.Abstract;

namespace OOP.Animals.Abstract
{
    abstract class Animal
    {
        private string _name;
        private int _age;

        protected WorldEnvironment Environment;

        public void SetEnvironment(WorldEnvironment environment)
        {
            Environment = environment;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

     
        public abstract void MakeNoise();
        public abstract void Eat();
    }
}

