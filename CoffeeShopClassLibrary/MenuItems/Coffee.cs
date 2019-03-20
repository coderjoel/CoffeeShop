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
        public new String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public new decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public Coffee()
        {
            this._Description = "Black Coffee";
            this._BaseCost =2M;
        }

        public override string GetInfo()
        {
            return "\nMenu Item\nName : Coffee" + "\nDescription :" + _Description + "\nBase cost :$" + _BaseCost;
        }
    }
}
