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
            this._MenuItem = item;
        }

        public String GetInfo()
        {
            return string.Format("Name: {0}\nDescription: {1}\nCost: {2}\n", _MenuItem.Name, _MenuItem.Description, _MenuItem.BaseCost);
        }
    }
}
