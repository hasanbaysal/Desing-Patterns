using Factory_Design_Pattern.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.Concreate_Factory
{
    public class AFactory : IFactory
    {

        public Product CreateProduct(int price,string color)
        {
            return new AProduct(price,color);
        }
    }
}
