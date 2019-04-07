using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
	[Serializable]
	public class MenuItemAddition : MenuItem
	{
		private MenuItem _Item;

		public MenuItem Item { get => _Item; set => _Item = value; }

		public MenuItemAddition(MenuItem item)
		{
			_Item = item;
		}

		public override string ToString()
		{
			return String.Format(GetInfo());
		}

		public override string GetInfo()
		{
			return $"\nMenuItem:\t-Description\t: {GetDescription()}\n\t\t-Cost\t\t: ${GetBaseCost()}";
		}

		private string GetDescription()
		{

			if (Item is MenuItemAddition)
			{
				return this.Description = ((MenuItemAddition)Item).GetDescription() + ", " + Description;
			}
			else
			{
				return Description = Item.Description + ", " + Description;
			}
		}

		private decimal GetBaseCost()
		{
			decimal cost = this.BaseCost;

			if (Item is MenuItemAddition)
			{
				return BaseCost = ((MenuItemAddition)Item).GetBaseCost() + BaseCost;
			}
			else
			{
				return BaseCost = Item.BaseCost + BaseCost;
			}
		}
	}
}

