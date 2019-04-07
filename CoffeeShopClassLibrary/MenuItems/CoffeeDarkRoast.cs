using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
	public class CoffeeDarkRoast : MenuItem
	{
		public CoffeeDarkRoast()
		{
			Description = "Dark Roast Coffee";
			BaseCost = 2.00M;
		}
	}
}
