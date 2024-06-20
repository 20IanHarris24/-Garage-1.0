using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal class Motorcycle : Vehicle , IVehicle
    {

        private int _numberOfSeats;
        
        public int NumberOfSeats { get { return _numberOfSeats; } set { _numberOfSeats = value; } }
        
        //public int CylinderVolume { get; set; }
        //public string? FuelType { get; set; }
        //public int Length { get; set; }

        public Motorcycle(int noOfSeats, string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels) : base(vehicleType, vehicleEngineType, vehicleColour, vehicleNumberOfWheels)
        {

            _numberOfSeats = noOfSeats;
            
            //FuelType = fuel;
            //NumberOfSeats = seats;
            //Length = size;
            //_engineType = VehicleEngineType;
            //VehicleColour = VehicleColour;
            //VehicleNumberOfWheels = VehicleNumberOfWheels;
            //_airReg = VehicleRegistrationNumber;
            //_vehicleEngineType = VehicleEngineType;





        }


    }
}
