using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class CornToppingsDecorator : PizzaDecorator
    {
        public CornToppingsDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override int GetCost()
        {
            return base.GetCost() + 40;
        }

        public override string GetPizzaType()
        {
            return base.GetPizzaType() + " Extra Corn delight";
        }
    }
}
