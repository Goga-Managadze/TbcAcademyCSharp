using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class ShopComparer : IEqualityComparer<Shop> 
    {
        public bool Equals(Shop x, Shop y)
        {
            if (x.ShopId == y.ShopId && x.ShopName.ToLower() == y.ShopName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Shop obj)
        {
            return obj.ShopId.GetHashCode();
        }
    }
}
