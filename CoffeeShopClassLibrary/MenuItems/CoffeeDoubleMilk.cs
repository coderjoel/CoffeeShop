using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class CoffeeDoubleMilk : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public CoffeeDoubleMilk()
        {
            this._Description = "Coffee with two milks";
            this._BaseCost = 2.20M;
        }
    }
}
