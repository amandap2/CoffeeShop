using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Milk : Add
    {
        public Milk(Beverage bev) : base(bev.Description(), bev)
        {
            _description = Description();
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.4;
        }

        public override string Description()
        {
            return beverage.Description() + " with milk";
        }
    }
}
