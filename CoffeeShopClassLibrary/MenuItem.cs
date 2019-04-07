using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
    public class MenuItem : IMenuItem
	{
		[JsonProperty]
		private String _Description;
        public String Description { get=>_Description; set=>_Description=value; }
		[JsonProperty]
		private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public MenuItem(String description, decimal cost)
        {
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

        public virtual string GetInfo()
        {
            return "\nMenu Item\t-Description\t: " + _Description + "\n\t\t-Cost\t\t: $" + _BaseCost;
        }

    }
}
