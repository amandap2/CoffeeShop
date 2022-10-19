using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public abstract class Add : Beverage
    {
        protected Beverage beverage;

        public Add(string description, Beverage bev) : base(description)
        {
            _description = description;
            beverage = bev;
        }
        public abstract string Description();
    }
}
