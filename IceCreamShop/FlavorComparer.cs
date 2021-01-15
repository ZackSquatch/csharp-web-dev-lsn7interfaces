using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            return(x.Allergens.Count - y.Allergens.Count) < 0.0 ? -1 : 1;
        }
    }
}
