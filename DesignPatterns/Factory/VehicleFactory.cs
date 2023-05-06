using DesignPatterns.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public static class VehicleFactory
    {
        private static string? _vehicleType;

        public static IVehicle? CreateVehicleObject(string vehicleType)
        {
            _vehicleType = vehicleType;
            if (_vehicleType.ToLower() == "car")
            {
                return new Car();
            }
            else if (_vehicleType.ToLower() =="bike")
            {
                return new Bike();
            }
            else if (vehicleType.ToLower() == "bus")
            {
                return new Bus();
            }
            else
            {
                return null;
            }
        }
    }
}
