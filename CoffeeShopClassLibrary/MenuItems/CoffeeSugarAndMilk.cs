using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    class CoffeeSugarAndMilk : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public CoffeeSugarAndMilk(string description, decimal cost)
        {
            this._Description = description;
            this._BaseCost = cost;
        }
    }
}
