using Factory_Design_Pattern.Abstract_Factory;
using Factory_Design_Pattern.Concreate_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.Concreate_Factory
{
    public class BFactory : IFactory
    {

        public Product CreateProduct(int price, string color)
        {
            return new BProduct(price, color);
        }
    }
}
