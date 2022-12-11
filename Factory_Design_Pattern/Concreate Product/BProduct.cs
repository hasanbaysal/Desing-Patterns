using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.Concreate_Product
{
    internal class BProduct : Product
    {
        public BProduct(int price, string color) : base(price, color)
        {
            
        }
    }
}
