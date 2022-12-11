using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public abstract class Product
    {
        private int _Price;
        private string _Color;
        protected Product(int price, string color)
        {
            _Price = price;
            _Color = color;
        }
       
        public int Price
        {
            get
            {
                return _Price;
            }
        }
        public string Color
        {
            get
            {
                return _Color;
            }
        }

    }
}
