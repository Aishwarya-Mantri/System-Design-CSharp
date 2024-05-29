using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    public class AdvanceDriveStrategy : DriveStrategy
    {
        public override void Drive()
        {
            Console.WriteLine("Advance Drive Strategy");
        }
    }
}
