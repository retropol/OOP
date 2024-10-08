using OOP.Animals.Abstract;

namespace OOP.Animals.Concrete
{
    class Kartal : FlyingAnimals
    {

        private int _enerjiseviyesi = 10;

        public int Enerjiseviyesi
        {

            get => _enerjiseviyesi;
            set => _enerjiseviyesi = value;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Kartal: Ciyak!");
        }

        public override void Fly()
        {
            if (_enerjiseviyesi >= ucmaninEnerjiSeviyesi)
            {

                _enerjiseviyesi -= ucmaninEnerjiSeviyesi;
                Console.WriteLine("Balık gibi yüzüyorum");
            }
            else { Console.WriteLine("Yüzmek için enerjin yok"); }
        }

    }

}
