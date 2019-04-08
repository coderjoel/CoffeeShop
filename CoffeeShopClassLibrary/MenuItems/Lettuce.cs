using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
	public class Lettuce : MenuItemAddition
	{
		public Lettuce(MenuItem menuItem) : base(menuItem)
		{
			Item = menuItem;
			Description = "Lettuce";
			BaseCost = 0.10M;
		}
	}
}
