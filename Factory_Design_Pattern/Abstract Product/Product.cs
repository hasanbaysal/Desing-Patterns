using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public abstract class Product
    {
        protected Product(int price, string color)
        {
            Price = price;
            Color = color;
        }
        private int Price { get; set; }
        private string Color { get; set; }

    }
}
