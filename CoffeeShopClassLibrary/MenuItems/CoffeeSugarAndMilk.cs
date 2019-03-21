using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class CoffeeSugarAndMilk : MenuItem
    {
        public CoffeeSugarAndMilk()
        {
            Description = "Coffee with single sugers and single milk";
            BaseCost = 2.15M;
        }
    }
}
