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
        private Garage<Vehicle> _theGarage;
        private int _availableSpaces;

       public Garage<Vehicle> TheGarage { get { return _theGarage; } }

        public int SpaceCount { get { return _availableSpaces; } set { _availableSpaces = value; } }
        //public int AvailableSpace { get { return _availableSpaces; } set { _availableSpaces = value; } }
        public int ParkingSpace { get { return TheGarage.VehicleSpaces.Length; } }  // set { _parkingSpaces = value; } }

       
        public GarageHandler(int capacity)
        {
            _theGarage = new Garage<Vehicle>(capacity);
                
        }

              


        public bool Park(Vehicle vehicle)
        {
            bool parkingStatus = false;

            if (TheGarage.HasNoGarageSpace)
            {
                
                parkingStatus = false;
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("\nSorry the Garage is full. Try again later");
                //Console.ResetColor();
            }
            //if (TheGarage.HasGarageSpace)
            else
            {
                //parkingStatus = true;
                parkingStatus = TheGarage.ParkVehicle(vehicle);
                
                //var parkVehicle = Array.IndexOf(TheGarage.VehicleSpaces, null);
                //if (parkVehicle != -1)
                //{
                //    TheGarage.VehicleSpaces![parkVehicle] = vehicle;                           //finding an empty parking spot and parking the vehicle
                    //GetGarageAndPark();
                    SpaceCount--;

            }
                /*else if (parkVehicle == -1)
                {
                    parkingStatus = false;
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("\nSorry the Garage is full. Try again later");
                    //Console.ResetColor();
                }*/
            return parkingStatus;
        }

        public bool Leave(Vehicle vehicle)
        {
            bool parkingStatus = false; 


            
            //ArgumentNullException.ThrowIfNull(VehicleGarage);

            if (SpaceCount == ParkingSpace)
            {
                parkingStatus = false;
            }
            //if (TheGarage.VehicleSpaces.Length)
            else
            {
                //var removeVehicle = Array.IndexOf(TheGarage.VehicleSpaces, vehicle);
                //Garage <Vehicle> updateGarage = new Garage<Vehicle>(TheGarage.VehicleSpaces.Length);
                parkingStatus = TheGarage.RemoveVehicle(vehicle);

                //for (int i = 0; i < TheGarage.VehicleSpaces.Length; i++)
                //{
                //    if (i == removeVehicle)
                //    {
                //        SpaceCount++;                                                    // vehicle removed from the array ('Left the garage)
                //        continue;
                //    }
                //    else
                //    {
                //        updateGarage.VehicleGarage.SetValue(_vehicleGarage.VehicleGarage.ElementAt(i), i); //filling up the copy array with the cars that vehicles that are left after

                //    }
                //}
                        //parkingStatus = true;

            }

            PayParking(vehicle);
            Console.ResetColor();
            return parkingStatus;
        }
        public bool PayParking(Vehicle vehicle)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n{vehicle._vehicleRegistrationNumber} has paid the parking charge and left the Garage");
            Console.ResetColor();
            return true;
        }


        public IEnumerable<Vehicle> GetVehicles()
        {
            return TheGarage.VehicleSpaces.ToList();

        }

        public IEnumerable<Vehicle> GetVehicle()
        {
            throw new NotImplementedException();
        }

        public void DisplayVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine($"\n Vehicle Type: \t{vehicle.VehicleType}\n Registration Number: \t{vehicle.VehicleRegistrationNumber}\n Vehicle Engine: \t{vehicle.VehicleEngineType}\n Vehicle Colour: \t{vehicle.VehicleColour}\n Vehicle Wheels: \t{vehicle.VehicleNumberOfWheels}");
        }

        public void DisplayVehicleDetails() 
        {
            throw new NotImplementedException();
        }
    }


    /*internal class GarageHandler : IHandler
    {
        private Garage<IVehicle> thisGarage;

        private IEnumerable<IVehicle> query;
        public void InitGarage()
        {
            thisGarage.Add(new Boat("ABC123", "Red", 3, 27));
            thisGarage.Add(new Car("DEF456", "White", 4, 1.64));
            thisGarage.Add(new Bus("GHI789", "Black", 6, 24));
            thisGarage.Add(new Car("JKL101", "Blue", 4, 19));
            thisGarage.Add(new Motorcycle("MNO112", "Blue", 2, "Diesel"));
        }

        //Kan kanske förbättra/skriva ihop med något annat
        public List<IVehicle> GetGarage()
        {
            //List<IVehicle> output = new List<IVehicle>();
            //foreach (var vehicle in thisGarage)
            //{
            //    if (vehicle != null) { 
            //        output.Add(vehicle);
            //    }
            //}
            //return output;
            return thisGarage.ToList();
        }

        public IVehicle? GetFromRegNr(string regNr)
        {
            return thisGarage.FirstOrDefault(vehicle => vehicle.RegNr.ToLower() == regNr.ToLower());
            //foreach (var vehicle in thisGarage)
            //{
            //    if (vehicle.RegNr.ToLower() == regNr.ToLower())
            //    {
            //        return vehicle;
            //    }
            //}
            //return null;
        }

        public void AddVehicle(IVehicle vehicle)
        {
            thisGarage.Add(vehicle);
        }


        public bool RemoveVehicle(string regNr)
        {
            return thisGarage.Unpark(regNr);
        }

        public GarageHandler(int capacity)
        {
            thisGarage = new Garage<IVehicle>(capacity);
        }

        public int NrOfType(string type)
        {
            return thisGarage.Where(v => v.GetType().Name == type).Count();*/

            //List<IVehicle> output = new List<IVehicle>();
            //foreach(var vehicle in thisGarage)
            //{
            //    string currType = vehicle.GetType().Name;//.ToString().Split('.').Last();
            //    if (currType == type)
            //    {
            //        output.Add(vehicle);
            //    }
            //}
            //return output;

        /*public bool IsFull()
        {
            return thisGarage.IsFull;
        }

        public void InitFilter()
        {
            query = thisGarage;
        }
        public void Filter(string typeQ, string typeS, int typeI)
        {
            if (query == null)
            {
                InitFilter();
            }

            if (typeQ == "type")
            {
                query = query.Where(p => p.GetType().Name == typeS);
                return;
            }
            else if (typeQ == "color")
            {
                query = query.Where(p => p.Color.ToLower() == typeS.ToLower());
                return;
            }
            else if (typeQ == "wheels")
            {
                query = query.Where(p => p.Wheels == typeI);
                return;
            }
        }

        public List<IVehicle> PrintFilter()
        {

            return query.ToList();
        }

    }*/



}




















































