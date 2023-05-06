using DesignPatterns.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Car:IVehicle
    {
        private int _noOfWheels = 2;
        private string _vehicleName = "Lamborgini";
        public int GetNumberOfWheels()
        {
            return _noOfWheels;
        }

        public string GetVehicleName()
        {
            return _vehicleName;
        }
    }
}
