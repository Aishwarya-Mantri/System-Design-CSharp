using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual int GetCost()
        {
            return _pizza.GetCost();
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }
}
