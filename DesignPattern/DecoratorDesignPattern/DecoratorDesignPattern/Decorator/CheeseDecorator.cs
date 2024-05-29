using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class CheeseDecorator: PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override int GetCost()
        {
            return base.GetCost() + 60;
        }

        public override string GetPizzaType()
        {
            return base.GetPizzaType() + " Extra Cheesy";
        }
    }
}
