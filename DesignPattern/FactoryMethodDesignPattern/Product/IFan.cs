using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Product
{
    internal interface IFan
    {
        bool Fan { get; set; }
        void SwitchOn();
        void SwitchOff();
    }
}
