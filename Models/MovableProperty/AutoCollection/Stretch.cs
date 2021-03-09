using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Models.Enums;

namespace Taxi.Models.MovableProperty.AutoCollection
{
    public class Stretch : Limousine
    {
        public Stretch(double price, double weight, string manufacturedBy, int maxAllowedSpeed, int initCost, string name, bool leftWeelSide)
            : base(price, weight, manufacturedBy, maxAllowedSpeed, initCost, name, leftWeelSide)
        {
        }

        public override Facilities[] Сomposition => new Facilities[] { Facilities.CardPay, Facilities.CashPay, Facilities.NoLeather, Facilities.Water };

        public override string Name => "Crown Victoria S";
        public override TypeOfLuggage TypeOfLuggage => TypeOfLuggage.Big;
        public override int PassangersCount => 8;
    }
}
