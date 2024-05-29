using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Product
{
    internal class TableFan : IFan
    {
        private bool IsOn { get; set; }
        public bool Fan { get => IsOn; set => IsOn = value; }

        public void SwitchOff()
        {
            Fan = false;
        }

        public void SwitchOn()
        {
            Fan = true;
        }
    }
}
