using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal class Airplane : Vehicle , IVehicle
    {
        private int _numberOfEngines;
        //private string? _engineType;
        //private string? _fuelType;
        //private string? _airReg;
        //private int _noOfWheels;
        //private int _numberOfSeats;
        //private int _length;


        public int NumberOfEngines  { get { return _numberOfEngines; } set { _numberOfEngines = value; }}
        
        //public string? FuelType { get; set; }
        //public int NumberOfSeats { get; set; }
        //public int Length { get; set; }




        public Airplane(int noOfEngines, string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels) : base (vehicleType,vehicleEngineType,vehicleColour,vehicleNumberOfWheels)
        {
            
            NumberOfEngines = noOfEngines;
            
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
