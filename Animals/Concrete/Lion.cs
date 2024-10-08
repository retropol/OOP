using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Lion : LandAnimals
    {

        private int _enerjiseviyesi = 10;

        public int Enerjiseviyesi
        {

            get => _enerjiseviyesi;
            set => _enerjiseviyesi = value;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("VOAARR");

        }
        public override void Run()
        {
            if (_enerjiseviyesi >= kosmaninEnerjiSeviyesi)
            {

                _enerjiseviyesi -= kosmaninEnerjiSeviyesi;
                Console.WriteLine("Balık gibi yüzüyorum");
            }
            else { Console.WriteLine("Yüzmek için enerjin yok"); }
        }
    }

}
