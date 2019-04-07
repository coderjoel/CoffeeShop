using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary
{
	public interface IMenuItem
	{
		string Description { get; set; }
		decimal BaseCost { get; set; }
	}
}
