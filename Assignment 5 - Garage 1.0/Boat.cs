using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal class Boat : Vehicle , IVehicle
    {

        private double _length;

        public double Length { get { return _length; } set { _length = value; } }

        //public int NumberOfEngines { get; set; }
        //public string? FuelType { get; set; }
        //public int NumberOfSeats { get; set; }
      

        public Boat(double length, string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels) : base(vehicleType, vehicleEngineType, vehicleColour, vehicleNumberOfWheels)
        {

            _length = length;
           
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
