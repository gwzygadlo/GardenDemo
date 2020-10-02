using System;
namespace TowerGame.Generics.Gabriela
{
    public class Onion : IGetPlantable
    {

        public Onion()
        {
        }

        public Onion(string taste, bool isSmelly)
        {
            this.Taste = taste;
            this.IsSmelly = isSmelly;
        }

        public string Taste { get; set; }
        public bool IsSmelly { get; set; }
        public string PlantType => "onion";

        public string DescribePlant()
        {
            return string.Format("The onion tastes {0}. Does the onion smell? {1}.", this.Taste, this.IsSmelly.ToString());
        }
    }
}
