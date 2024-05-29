using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SportsVehicle : Vehicle
    {
       public SportsVehicle() : base(new AdvanceDriveStrategy())
       {

       }
    }
}