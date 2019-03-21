using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public class OrderItem
    {
        private MenuItem _MenuItem;
        public MenuItem MenuItem{get=> _MenuItem;}

        public OrderItem(MenuItem item)
        {
            _MenuItem = item;
        }

        public String GetInfo()
        {
            return string.Format("\nDescription: {0}\nCost: {1}\n", _MenuItem.Description, _MenuItem.BaseCost);
        }
    }
}
