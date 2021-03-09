using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Models.MovableProperty
{
    public abstract class Car
    {
        protected Car(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name)
        {
            Price = price;
            ManufacturedBy = manufacturedBy;
            MaxAllowedSpeed = maxAllowedSpeed;
            Weight = weight;
            InitCost = initCost;
        }

        public double Price { get; }

        public string ManufacturedBy { get; }

        public int MaxAllowedSpeed { get; }

        public double Weight { get; }

        public abstract string Name { get; }
        public int InitCost { get; set; }
    }
}
