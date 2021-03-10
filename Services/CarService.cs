using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Services.Abstractions;
using Taxi.Models.MovableProperty;
using Taxi.Models.MovableProperty.AutoCollection;
using Taxi.Models.Result;

namespace Taxi.Services
{
    public class CarService : ICarService
    {
        public CarService()
        {
            CombineGarage();
        }

        public double TotalWeight { get; set; }
        public Car[] Cars { get; set; }

        public void CombineGarage()
        {
            Cars = new Car[]
            {
                new RetroCab(15, 1200, "FORD", 90, 12000, "TownCar", true, Models.Enums.TypeOfDriver.BlackMan, true),
                new Stretch(200, 2000, "TOYOTA", 140, 200000, "Solara S", false, "Down Town", true, 9),
                new RetroCab(20, 1300, "Nissan", 110, 10000, "Grasshopper", false, Models.Enums.TypeOfDriver.WhiteMan, false),
                new Stretch(250, 2200, "Lincoln", 130, 220000, "Stretch", true, "Down Town and East Side", false, 7),
                new Stretch(150, 1500, "SsangYoung", 90, 60000, "Great", false, "West and Middle", false, 8),
            };

            TotalWeight = 0;
            for (var i = 0; i < Cars.Length; i++)
            {
                TotalWeight += Cars[i].Weight;
            }
        }
    }
}
