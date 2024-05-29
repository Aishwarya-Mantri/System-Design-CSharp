using StrategyPattern.Strategy;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Base class
            Vehicle v = new Vehicle(new DriveStrategy());
            v.Drive();

            //Derived Class
            PassengerVehicle p = new PassengerVehicle();
            p.Drive();

            //Derived class object assigned to base class pointer
            Vehicle vehicle = new SportsVehicle();
            vehicle.Drive();

            Vehicle vehicle1 = new HeavyDutyVehicle();
            vehicle1.Drive();


            // we can't assign base class object to dervice class pointer: downcasting not allowed, compile time error
            //PassengerVehicle p = new Vehicle(new NormalDriveStrategy());


            Console.ReadKey();
        }
    }
}
