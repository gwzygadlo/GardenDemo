using System;
using System.Collections.Generic;

namespace TowerGame.Generics.Gabriela
{
    public class Greenhouse<T>
        where T : IGetHarvestable
    {
        public Greenhouse()
        {
        }

        public Greenhouse(params IGetHarvestable[] harvestsInGreenhouse)
        {
            this.HarvestedItems = harvestsInGreenhouse;
        }

        public IGetHarvestable[] HarvestedItems { get; set; }
        public IGetHarvestable HarvestedItem { get; set; }
        public int countHarvestedItems
        {
            get
            {
                return this.HarvestedItems.Length;
            }
        }

        public void PrintHarvestedItems()
        {
            for (int i = 0; i < countHarvestedItems; i++)
            {
                IGetHarvestable HarvestedItem = this.HarvestedItems[i];
                this.PrintHarvestedItem(HarvestedItem);
            }
        }

        public void PrintHarvestedItem(IGetHarvestable HarvestedItem)
        {
            Console.WriteLine(HarvestedItem.Harvest());
        }
    }
}
