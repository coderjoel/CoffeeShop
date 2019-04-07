using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public class OrderItem
    {
        private IMenuItem _MenuItem;
        public IMenuItem MenuItem{get=> _MenuItem; set => _MenuItem = value; }

        public OrderItem(IMenuItem MenuItem)
        {
            _MenuItem = MenuItem;
        }

        public String GetInfo()
        {
            return string.Format("\nDescription: {0}\nCost: {1}\n", MenuItem.Description, MenuItem.BaseCost);
        }
    }
}
