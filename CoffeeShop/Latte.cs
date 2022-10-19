using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Latte : Beverage
    {
        public Latte(string description) : base(description)
        {
            _description = description;
        }

        public override double Cost()
        {
            return 5.50;
        }
    }
}
