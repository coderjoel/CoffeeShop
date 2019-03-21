using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class SandwichWithBacon : MenuItem
    {
        public SandwichWithBacon()
        {
            Description = "White bread sendwitch with bacon";
            BaseCost = 5M;
        }
    }
}
