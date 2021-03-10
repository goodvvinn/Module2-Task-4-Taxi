using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Models.MovableProperty.AutoCollection
{
    public abstract class Limousine : Premium
    {
        public Limousine(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide, string operatingZone, bool nightOperating)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name, leftWeelSide, nightOperating)
        {
            OperatingZone = operatingZone;
        }

        public string OperatingZone { get; set; }
    }
}
