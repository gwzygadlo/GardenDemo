using System;
namespace TowerGame.Generics.Gabriela
{
    public interface IGetHarvestable
    {
        int CountPlants { get; }

        string Harvest();
    }
}
