using OOP.Animals.Concrete;

namespace OOP.Animals.Abstract
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public abstract void MakeNoise();
    }




}