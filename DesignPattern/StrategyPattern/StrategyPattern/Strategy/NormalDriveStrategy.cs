using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy
{
    public class NormalDriveStrategy : DriveStrategy
    {
        public override void Drive()
        {
            Console.WriteLine("Normal Drive Strategy");
        }
    }
}
