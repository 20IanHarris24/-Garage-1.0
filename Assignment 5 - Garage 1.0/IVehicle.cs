using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal interface IVehicle
    {
        string? VehicleType { get; set; }
        string? VehicleEngineType { get; set;}
        VehicleColour VehicleColour { get; set; }
        int VehicleNumberOfWheels { get; set;}
        string? VehicleRegistrationNumber { get; }


        //void IVehicle(string? vehicleType, string? vehicleEngineType, VehicleColour vehicleColour, int vehicleNumberOfWheels);

        void DriveVehicle(Vehicle vehicle);

        void DisplayVehicleDetails(Vehicle vehicle);

    }
}
