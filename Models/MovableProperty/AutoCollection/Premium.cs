using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.Enums;

namespace Taxi.Models.MovableProperty.AutoCollection
{
    public abstract class Premium : Sedan
    {
        protected Premium(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide, bool nightOperating)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name, leftWeelSide)
        {
            NightOperating = nightOperating;
        }

        public bool NightOperating { get; set; }

        public abstract TypeOfLuggage TypeOfLuggage { get; }
    }
}
