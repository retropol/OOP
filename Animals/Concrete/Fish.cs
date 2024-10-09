using OOP.Animals.Abstract;
using OOP.Environments.Abstract;
namespace OOP.Animals.Concrete
{
    class Fish : SwimmingAnimals
    {
        private int _enerjiseviyesi = 10;
        
        public int Enerjiseviyesi { 

            get => _enerjiseviyesi; 
            set => _enerjiseviyesi = value; }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating in {Environment.Name}.");
        }



        public override void MakeNoise()
        {
            Console.WriteLine("Balık: Icant even make noise bro");
        }
        public override void Swim()
        {
            if (_enerjiseviyesi >= yuzmeninEnerjiSeviyesi)
            {

                _enerjiseviyesi -= yuzmeninEnerjiSeviyesi;
                Console.WriteLine("Balık gibi yüzüyorum");
            }
            else { Console.WriteLine("Yüzmek için enerjin yok"); }
           
        }
    }
}
