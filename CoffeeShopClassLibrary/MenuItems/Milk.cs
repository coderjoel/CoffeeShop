using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
	public class Milk : MenuItemAddition
	{
		public Milk(MenuItem menuItem) : base(menuItem)
		{
			Item = menuItem;
			Description = "Milk";
			BaseCost = 0.10M;
		}
	}
}
