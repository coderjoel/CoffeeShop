using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public class MenuItem
    {

        private String _Description;
        public String Description { get=>_Description; set=>_Description=value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public MenuItem(String description, decimal cost)
        {
            //this._Name = name;
            _Description = description;
            _BaseCost = cost;
        }
        public MenuItem()
        {

        }

        public override string ToString()
        {
            return GetInfo();
        }

        public String GetInfo()
        {
            //return "\nMenu Item\nName :" + _Name + "\nDescription :" + _Description+ "\nBase cost :$" + _BaseCost;
            return "\nMenu Item\nDescription :" + _Description + "\nBaseCost :$" + _BaseCost;
        }

    }
}
