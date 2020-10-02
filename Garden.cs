using System;
using System.Collections.Generic;

namespace TowerGame.Generics.Gabriela
{
    public class Garden<T> : IGetHarvestable
        where T : IGetPlantable
    {
        public Garden()
        {
        }

        public Garden(params T[] plantsInGarden)
        {
            this.Plants = plantsInGarden;
        }


        public string GardenPlantType => this.Plants[0].PlantType;

        public T[] Plants { get; set; }
        public int CountPlants => this.Plants.Length;

        public void PrintPlants()
        {
            for (int i = 0; i < CountPlants; i++)
            {
                T Plant = this.Plants[i];
                this.PrintPlant(Plant);
            }
        }

        public void PrintPlant(T Plant)
        {
            Console.WriteLine(Plant.DescribePlant());
        }

        public string Harvest()
        {
            return string.Format("This garden has {1} harvestable {0} plants.", this.GardenPlantType, CountPlants);
        }
    }
}
