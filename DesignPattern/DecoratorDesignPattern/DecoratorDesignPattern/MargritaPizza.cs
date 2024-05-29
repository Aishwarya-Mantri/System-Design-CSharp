using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
   public class MargritaPizza : PizzaBase
    {
        public override int GetCost()
        {
            return 120;
        }

        public override string GetPizzaType()
        {
            return "Margartia Pizza";
        }
    }
}
