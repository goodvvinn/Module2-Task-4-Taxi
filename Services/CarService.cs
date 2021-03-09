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
                new RetroCab(15, 1200, "FORD", 90, 12000, "TownCar", true, Models.Enums.TypeOfDriver.BlackMan),
                new Stretch(200, 2000, "TOYOTA", 140, 200000, "Solara S", false),
                new RetroCab(20, 1300, "Nissan", 110, 10000, "Grasshopper", false, Models.Enums.TypeOfDriver.WhiteMan),
                new Stretch(250, 2200, "Lincoln", 130, 220000, "Stretch", true),
                new Stretch(150, 1500, "SsangYoung", 90, 60000, "Great", false),
            };

            TotalWeight = 0;
            for (var i = 0; i < Cars.Length; i++)
            {
                TotalWeight += Cars[i].Weight;
            }
        }
    }
}
