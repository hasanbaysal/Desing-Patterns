﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.Abstract_Factory
{
    public interface IFactory
    {
        Product CreateProduct(int price, string color);
    }
}
