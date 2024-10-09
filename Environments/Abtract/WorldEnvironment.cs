namespace OOP.Environments.Abstract
{
    abstract class WorldEnvironment
    {
        
        private string _name;
        private string _climate;

        // Constructor
        public WorldEnvironment(string name, string climate)
        {
            Name = name;
            Climate = climate;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Climate
        {
            get => _climate;
            set => _climate = value;
        }
       

        public abstract void DisplayInfo();
    }
}
