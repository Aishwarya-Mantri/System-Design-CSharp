using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Vehicle
    {
        private readonly DriveStrategy _driveStrategy;
        public Vehicle(DriveStrategy driveStrategy)
        {
            _driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            _driveStrategy.Drive();
        }
    }
}
