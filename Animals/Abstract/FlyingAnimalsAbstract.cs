namespace OOP.Animals.Abstract
{
    interface ICanFly
    {
        void Fly();
    }

    abstract class FlyingAnimals : Animal, ICanFly
    {
        public abstract void Fly();
    }
}
