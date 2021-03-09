using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Taxi.Models.MovableProperty;

namespace Taxi.Helpers.Comparers
{
    public class CarComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as Car;
            var y = second as Car;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
