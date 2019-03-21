﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.MenuItems
{
    public class SandwichWithBacon : MenuItem
    {
        private String _Description;
        public String Description { get => _Description; set => _Description = value; }

        private decimal _BaseCost;
        public decimal BaseCost { get => _BaseCost; set => _BaseCost = value; }

        public SandwichWithBacon()
        {
            this._Description = "White bread sendwitch with bacon";
            this._BaseCost = 5M;
        }
    }
}
