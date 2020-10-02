using System;
namespace TowerGame.Generics.Gabriela
{
    public class Rose : IGetPlantable
    {

        public Rose()
        {
        }

        public Rose(string color, double height)
        {
            this.Color = color;
            this.Height = height;
        }

        public string Color { get; set; }
        public double Height { get; set; }
        public string PlantType => "rose";

        public string DescribePlant()
        {
            return string.Format("The {0} rose is {1} inches tall. The rose smells sweet.", this.Color, this.Height.ToString());
        }
    }
}
