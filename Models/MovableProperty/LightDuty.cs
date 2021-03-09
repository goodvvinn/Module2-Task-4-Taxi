using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Models.MovableProperty
{
    public abstract class LightDuty : Car
    {
        protected LightDuty(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name)
        {
        }

        public abstract int PassangersCount { get; }
    }
}
