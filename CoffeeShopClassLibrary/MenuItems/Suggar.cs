using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
	public class Suggar : MenuItemAddition
	{
		public Suggar(MenuItem menuItem) : base(menuItem)
		{
			Item = menuItem;
			Description = "Sugar";
			BaseCost = 0.05M;
		}
	}
}
