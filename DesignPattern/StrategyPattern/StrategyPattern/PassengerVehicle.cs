using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PassengerVehicle : Vehicle
    {
       public PassengerVehicle() : base(new NormalDriveStrategy())
       {

       }
    }
}
