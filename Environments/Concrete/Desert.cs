using OOP.Environments.Abstract;


namespace OOP.Environments.Concrete
{
     class Desert : WorldEnvironment
    {
        public Desert() : base("Desert", "Arid")
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Environment: {Name}, Climate: {Climate}");
        }

    }
}
