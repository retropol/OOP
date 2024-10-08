using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Fish : SwimmingAnimals
    {
        private int _enerjiseviyesi = 10;
        
        public int Enerjiseviyesi { 

            get => _enerjiseviyesi; 
            set => _enerjiseviyesi = value; }


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
