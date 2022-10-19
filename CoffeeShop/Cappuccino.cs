using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Cappuccino : Beverage
    {
        public Cappuccino(string description) : base(description)
        {
            _description = description;
        }

        public override double Cost()
        {
            return 5.00;
        }
    }
}
