using DesignPatterns.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Bus:IVehicle
    {
        private int _noOfWheels = 8;
        private string _vehicleName = "Mercedes Bus";
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
