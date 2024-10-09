using OOP.Environments.Abstract;

namespace OOP.Animals.Abstract
{
    interface ICanSwim
    {
        void Swim();
    }

    abstract class SwimmingAnimals : Animal, ICanSwim
    {
       
        public int yuzmeninEnerjiSeviyesi = 1;
        public abstract void Swim();


    }
}
