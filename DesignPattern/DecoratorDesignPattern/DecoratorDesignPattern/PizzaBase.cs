using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class PizzaBase : IPizza
    {
        public virtual int GetCost()
        {
            return 100;
        }

        public virtual string GetPizzaType()
        {
            return "Pizza base";
        }
    }
}
