using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class CoffeeDoubleDouble : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public CoffeeDoubleDouble()
        {
            this._Description = "Coffee with two sugers and two milks";
            this._BaseCost = 2.30M;
        }
    }
}
