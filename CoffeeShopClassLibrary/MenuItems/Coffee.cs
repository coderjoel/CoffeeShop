using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class Coffee : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public Coffee(string description, decimal cost)
        {
            this._Description = description;
            this._BaseCost = cost;
        }

        public override string GetInfo()
        {
            return "\nMenu Item\nName : Coffee" + "\nDescription :" + _Description + "\nBase cost :$" + _BaseCost;
        }
    }
}
