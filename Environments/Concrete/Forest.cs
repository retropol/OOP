using OOP.Environments.Abstract;

namespace OOP.Environments.Concrete
{
     class Forest : WorldEnvironment
    {

        public Forest() : base("Forest", "Temperate")
        {
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Environment: {Name}, Climate: {Climate}");
        }

    }
}