using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.Enums;

namespace Taxi.Models.MovableProperty.AutoCollection
{
    public class RetroCab : Econom
    {
        public RetroCab(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide, TypeOfDriver typeOfDriver)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name, leftWeelSide)
        {
            TypeOfDriver = typeOfDriver;
        }

        public TypeOfDriver TypeOfDriver { get; }
        public override string Name => "Lincoln Towncar";
        public override int PassangersCount => 3;
        public override TypePassangers TypeOfPassanger => TypePassangers.All;
        public override Facilities[] Сomposition => new Facilities[] { Facilities.CardPay, Facilities.Internet, Facilities.Water };
    }
}
