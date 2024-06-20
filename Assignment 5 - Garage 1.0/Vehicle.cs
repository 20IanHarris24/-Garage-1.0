using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment_5___Garage_1._0
{
    abstract class Vehicle
    {
        private string? _vehicleType;
        private string? _vehicleEngineType;
        private VehicleColour _vehicleColour;
        private int _vehicleNumberOfWheels;
        public string? _vehicleRegistrationNumber;




        public string? VehicleType { get { return _vehicleType; } set { _vehicleType = value; } }
        public string? VehicleEngineType { get { return _vehicleEngineType; } set { _vehicleEngineType = value; } }
        public VehicleColour VehicleColour { get { return _vehicleColour; } set { _vehicleColour = value; } }
        public int VehicleNumberOfWheels { get { return _vehicleNumberOfWheels; } set { _vehicleNumberOfWheels = value; } }
        public string? VehicleRegistrationNumber { get { return _vehicleRegistrationNumber; } private set { _vehicleRegistrationNumber = value; } }

        



        public Vehicle(string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels)
        {
            VehicleType = vehicleType;
            VehicleEngineType = vehicleEngineType;
            VehicleColour = vehicleColour;
            VehicleNumberOfWheels = vehicleNumberOfWheels;
            VehicleRegistrationNumber = GenerateRegNum.GenerateRandomRegNum();  //When the vehicle object instance is created a 'unique' registration number will be generated 
        }

        
        public void DriveVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.VehicleRegistrationNumber} is parking");
        }

                   
        public void DisplayVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine($"\n Vehicle Type: \t{vehicle.VehicleType}\n Registration Number: \t{vehicle.VehicleRegistrationNumber}\n Vehicle Engine: \t{vehicle.VehicleEngineType}\n Vehicle Colour: \t{vehicle.VehicleColour}\n Vehicle Wheels: \t{vehicle.VehicleNumberOfWheels}");
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
