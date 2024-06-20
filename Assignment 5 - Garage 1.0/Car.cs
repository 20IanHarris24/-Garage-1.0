using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal class Car : Vehicle , IVehicle
    {

        private double _cylinderVolume;
        private readonly new string? _vehicleRegistrationNumber;
                
        public double CylinderVolume { get { return _cylinderVolume; } set { _cylinderVolume = value; } }

        public new string?  VehicleRegistrationNumber { get { return _vehicleRegistrationNumber; } }

        
        //public string? FuelType { get; set; }
        //public int NumberOfSeats { get; set; }
        //public int Length { get; set; }

        public Car(double volume, string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels) : base(vehicleType, vehicleEngineType, vehicleColour, vehicleNumberOfWheels)
        {

            _cylinderVolume = volume;
            
            
            //FuelType = fuel;
            //NumberOfSeats = seats;
            //Length = size;
            //_engineType = VehicleEngineType;
            // VehicleColour = VehicleColour;
            // VehicleNumberOfWheels = VehicleNumberOfWheels;
            // _airReg = VehicleRegistrationNumber;

            // _vehicleEngineType = VehicleEngineType;





            
        }





    }
}
