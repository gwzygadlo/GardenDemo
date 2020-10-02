using System;
namespace TowerGame.Generics.Gabriela
{
    public class Daisy : IGetPlantable
    {

        public Daisy()
        {
        }

        public Daisy(string color, double height)
        {
            this.Color = color;
            this.Height = height;
        }

        public string Color { get; set; }
        public double Height { get; set; }
        public string PlantType => "daisy";

        public string DescribePlant()
        {
            return string.Format("The {0} daisy is {1} inches tall. The daisy is small and cute.", this.Color, this.Height.ToString());
        }
    }
}
