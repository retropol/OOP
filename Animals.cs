namespace OOP.Models.Abstract
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public abstract void MakeNoise();
    }

    interface ICanSwim
    {
        void Swim();
    }

    interface ICanFly
    {
        void Fly();
    }

    abstract class FlyingAnimals : Animal, ICanFly
    {
        public abstract void Fly();
    }

    abstract class SwimmingAnimals : Animal, ICanSwim
    {
        public abstract void Swim();
    }
    abstract class LandAnimals : Animal
    {

        public abstract void Run();
    }



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