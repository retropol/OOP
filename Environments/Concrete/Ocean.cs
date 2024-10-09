using OOP.Environments.Abstract;

namespace OOP.Environments.Concrete
{
     class Ocean: WorldEnvironment
    {

        public Ocean() : base("Ocean", "Tropical")
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Environment: {Name}, Climate: {Climate}");
        }
    }
}
