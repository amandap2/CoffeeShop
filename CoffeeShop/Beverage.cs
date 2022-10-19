using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public abstract class Beverage
    {
        public string _description { get; set; }

        public Beverage(string description)
        {
            _description = description;
        }

        public string Description()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
