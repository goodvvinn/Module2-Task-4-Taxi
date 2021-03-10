using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.Enums;

namespace Taxi.Models.MovableProperty.AutoCollection
{
    public abstract class Econom : Sedan
    {
        protected Econom(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide, bool englishSpeakingDriver)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name, leftWeelSide)
        {
            EnglishSpeakingDriver = englishSpeakingDriver;
        }

        public bool EnglishSpeakingDriver { get; set; }

        public abstract TypePassangers TypeOfPassanger { get; }
    }
}
