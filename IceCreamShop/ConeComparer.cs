using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            return (x.Cost - y.Cost) < 0.0 ? -1 : 1;
        }
    }
}