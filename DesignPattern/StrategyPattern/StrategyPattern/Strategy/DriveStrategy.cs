using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    public class DriveStrategy
    {
        public virtual void Drive()
        {
            Console.WriteLine("Default Drive Strategy");
        }
    }
}
