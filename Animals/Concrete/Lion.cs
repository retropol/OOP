using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Lion : LandAnimals
    {

        public override void MakeNoise()
        {
            Console.WriteLine("VOAARR");

        }
        public override void Run()
        {
            Console.WriteLine("Aslan Koşuyor");
        }
    }

}
