using OOP.Animals.Concrete;
using OOP.Environments.Abstract;
using OOP.Environments.Concrete;

namespace OOP.Worlds.Main
{
    class Program
    {

        static void Main(string[] args)
        {
            WorldEnvironment forest = new Forest();
    
            WorldEnvironment ocean = new Ocean();

            WorldEnvironment desert = new Desert();


            Kartal kartal = new Kartal();
            kartal.SetEnvironment(forest);
            kartal.Name = "Kaya";
            kartal.Age = 10;
            kartal.MakeNoise();
            kartal.Fly();
            kartal.Eat();


            Fish fish = new Fish();
            kartal.SetEnvironment(ocean);
            fish.Name = "Flipper";
            fish.Age = 15;
            fish.MakeNoise();
            fish.Swim();
            fish.Eat();

            Lion lion = new Lion();
            kartal.SetEnvironment(desert);
            lion.Name = "Simba";
            lion.Age = 55;
            lion.MakeNoise();
            lion.Run();
            lion.Eat();
        }


    }
}
