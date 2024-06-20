using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal interface IHandler
    {

        Garage<Vehicle> VGarage { get; }

        //void IHandler(int capacity);
        

        bool Park(Vehicle vehicle);
        
        bool Leave(Vehicle vehicle);
        bool Leave(bool v);
        bool PayParking(Vehicle vehicle);
        IEnumerable<Vehicle> GetVehicles();



        void DisplayVehicleDetails(Vehicle vehicle);
        


    }

}

