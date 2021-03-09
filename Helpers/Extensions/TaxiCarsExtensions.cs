using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.MovableProperty;
using Taxi.Models.Enums;

namespace Taxi.Helpers.Extensions
{
    public static class TaxiCarsExtensions
    {
        public static Car[] FindCar(this Car[] cars,  double weight)
        {
            int num = 0;

            for (var i = 0; i < cars.Length; i++)
            {
                if (cars[i].Weight <= weight)
                {
                    num++;
                }
            }

            var temp = new Car[num];

            int index = 0;
            for (var i = 0; i < cars.Length; i++)
            {
                if (cars[i].Weight <= weight)
                {
                    temp[index] = cars[i];
                    index++;
                }
            }

            return temp;
        }
    }
}
