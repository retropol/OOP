using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Fish : SwimmingAnimals
    {

        public override void MakeNoise()
        {
            Console.WriteLine("Balık: Icant even make noise bro");
        }
        public override void Swim()
        {
            Console.WriteLine("Balık gibi yüzüyorum");
        }
    }
}
