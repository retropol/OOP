namespace OOP.Animals.Abstract
{
    interface ICanFly
    {
       
        void Fly();
    }

    abstract class FlyingAnimals : Animal, ICanFly
    {
        public int ucmaninEnerjiSeviyesi = 1;
        public abstract void Fly();
    }
}
