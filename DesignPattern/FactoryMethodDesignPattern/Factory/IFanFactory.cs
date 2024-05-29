using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory
{
    internal interface IFanFactory
    {
        IFan CreateFan();
    }
}
