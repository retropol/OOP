using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Papagan : FlyingAnimals
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Papagan: hi my friend!");
        }

        public override void Fly()
        {
            Console.WriteLine("Papaan uçuyor.");
        }
    }
}
