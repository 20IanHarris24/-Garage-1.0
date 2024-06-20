using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Assignment_5___Garage_1._0.GarageHandler<T>;


namespace Assignment_5___Garage_1._0
{
    internal class GarageHandler : IHandler
    {
       private readonly Garage<Vehicle> _vehicleGarage;
       public Garage<Vehicle> VGarage { get { return _vehicleGarage; } }                


        public GarageHandler(int capacity)
        {
            _vehicleGarage = new Garage<Vehicle>(capacity);
                
        }

       


        public bool Park(Vehicle vehicle)
        {
            bool parkingStatus = false;

            if (_vehicleGarage.NoGarageSpace)
            {
                parkingStatus = false;
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("\nSorry the Garage is full. Try again later");
                //Console.ResetColor();
            }
            if (_vehicleGarage.GarageSpace)
            {
                parkingStatus = true;
                
                var parkVehicle = Array.IndexOf(_vehicleGarage.VehicleGarage, null);
                if (parkVehicle != -1)
                {
                    _vehicleGarage.VehicleGarage![parkVehicle] = vehicle;                           //finding an empty parking spot and parking the vehicle
                    
                    _vehicleGarage.SpaceCount--;

                }
                else if (parkVehicle == -1)
                {
                    parkingStatus = false;
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("\nSorry the Garage is full. Try again later");
                    //Console.ResetColor();
                }
            }

            return parkingStatus;
        }
        public bool Leave(Vehicle vehicle)
        {
            bool parkingStatus = false; 
            
            //ArgumentNullException.ThrowIfNull(VehicleGarage);

            if (_vehicleGarage.AvailableSpace == _vehicleGarage.ParkingSpace)
            {
                parkingStatus = false;
            }
            if (_vehicleGarage.GarageSpace)
            {
                var removeVehicle = Array.IndexOf(_vehicleGarage.VehicleGarage, vehicle);
                Garage <Vehicle> updateGarage = new Garage<Vehicle>(_vehicleGarage.VehicleGarage.Length);

                for (int i = 0; i < _vehicleGarage.VehicleGarage.Length; i++)
                {
                    if (i == removeVehicle)
                    {
                        _vehicleGarage.AvailableSpace++;                                                    // vehicle removed form the array ('Left the garage)
                        continue;
                    }
                    else
                    {
                        updateGarage.VehicleGarage.SetValue(_vehicleGarage.VehicleGarage.ElementAt(i), i); //filling up the copy array with the cars that vehicles that are left after

                    }
                }
                        parkingStatus = true;

            }

            //PayParking(vehicle);
            Console.ResetColor();
            return parkingStatus;
        }
        public static bool PayParking(Vehicle vehicle)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{vehicle._vehicleRegistrationNumber} has paid the parking charge and left the Garage");
            Console.ResetColor();
            return true;
        }


        public IEnumerable<Vehicle> GetVehicles()
        {
            return _vehicleGarage.VehicleGarage.ToList();

        }

        public IEnumerable<Vehicle> GetVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
