using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory
{
    internal class CeilingFanFactory : IFanFactory
    {
        public IFan CreateFan()
        {
            return new CeilingFan();
        }
    }
}
