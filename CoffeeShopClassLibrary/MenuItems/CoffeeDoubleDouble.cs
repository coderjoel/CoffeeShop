using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class CoffeeDoubleDouble : MenuItem
    {
        public CoffeeDoubleDouble()
        {
            Description = "Coffee with two sugers and two milks";
            BaseCost = 2.30M;
        }
    }
}
