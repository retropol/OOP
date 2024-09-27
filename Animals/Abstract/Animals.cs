using OOP.Animals.Concrete;

namespace OOP.Animals.Abstract
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public abstract void MakeNoise();
    }



    class Program
    {

        static void Main(string[] args)
        {
            Kartal kartal = new Kartal();
            kartal.Name = "Kaya";
            kartal.Age = "10";
            kartal.MakeNoise();
            kartal.Fly();

            Fish fish = new Fish();
            fish.Name = "Flipper";
            fish.Age = "15";
            fish.MakeNoise();
            fish.Swim();

            Lion lion = new Lion();
            lion.Name = "Simba";
            lion.Age = "55";
            lion.MakeNoise();
            lion.Run();
        }


    }
}