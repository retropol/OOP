namespace OOP.Animals.Abstract
{
    interface ICanSwim
    {
        void Swim();
    }

    abstract class SwimmingAnimals : Animal, ICanSwim
    {
        public abstract void Swim();
    }
}
