using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class CoffeeSugarAndMilk : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public CoffeeSugarAndMilk()
        {
            this._Description = "Coffee with single sugers and single milk";
            this._BaseCost = 2.15M;
        }
    }
}
