using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
	public class Sweetener : MenuItemAddition
	{
		public Sweetener(MenuItem menuItem) : base(menuItem)
		{
			Item = menuItem;
			Description = "Sweetener";
			BaseCost = 0.06M;
		}
	}
}
