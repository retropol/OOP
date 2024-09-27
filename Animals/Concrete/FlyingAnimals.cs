using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Kartal : FlyingAnimals
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Kartal: Ciyak!");
        }

        public override void Fly()
        {
            Console.WriteLine("Kartal uçuyor.");
        }
    }
}
