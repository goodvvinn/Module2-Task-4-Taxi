using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.Enums;

namespace Taxi.Models.MovableProperty
{
    public abstract class Sedan : LightDuty
    {
        protected Sedan(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name)
        {
            LeftWeelSide = leftWeelSide;
        }

        public bool LeftWeelSide { get; }

        public abstract Facilities[] Сomposition { get; }
    }
}
