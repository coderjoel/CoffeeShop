using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public class MenuItem
    {
        //private String _Name;
        //public String Name { get=>_Name; set=>_Name=value; }

        private String _Description;
        public String Description { get=>_Description; set=>_Description=value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public MenuItem(string name, string description, decimal cost)
        {
            //this._Name = name;
            this._Description = description;
            this._BaseCost = cost;
        }
        public MenuItem()
        {

        }

        public virtual string GetInfo()
        {
            //return "\nMenu Item\nName :" + _Name + "\nDescription :" + _Description+ "\nBase cost :$" + _BaseCost;
            return "\nMenu Item\nName : + "\nDescription :" + _Description + "\nBase cost :$" + _BaseCost;
        }

    }
}
