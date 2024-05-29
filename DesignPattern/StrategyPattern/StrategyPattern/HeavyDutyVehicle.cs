using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class HeavyDutyVehicle : Vehicle
    {
       public HeavyDutyVehicle() : base(new AdvanceDriveStrategy())
       {

       }
    }
}
