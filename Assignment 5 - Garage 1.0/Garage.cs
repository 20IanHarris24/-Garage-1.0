using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{

    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private int _parkingSpaces;
        private int _availableSpaces;
        private bool _park;
        private bool _remove;
        private T[] _vehicleGarage;

        public int Check => (_vehicleGarage.Length - _parkingSpaces);
        /*public int SpaceCount { get { return _availableSpaces; } set { _availableSpaces = value; } }*/
        public bool HasNoGarageSpace => _availableSpaces == Check;
        public bool HasGarageSpace => _availableSpaces <= _parkingSpaces;

        //public int AvailableSpace { get { return _availableSpaces; } set { _availableSpaces = value; } }
        //public int ParkingSpace { get { return _parkingSpaces; } set { _parkingSpaces = value; } }

        public T[] VehicleSpaces { get { return _vehicleGarage; } set { _vehicleGarage = value; } }




        public Garage(int spaces)                                                                      //Instantiate the garage based on the user input number of spaces 
        {
            _parkingSpaces = Math.Max(spaces, 2);
            _vehicleGarage = new T[_parkingSpaces];
            _availableSpaces = _parkingSpaces;                                                         //Assigning variables for checking the status of the garage
        }

        


        public bool ParkVehicle(T vehicle)                                                              //vehicle can 'Park' in the garage
        {
            _park = false;
            ArgumentNullException.ThrowIfNull(_vehicleGarage);

           /* if (HasNoGarageSpace)
            {
                _park = false;
                
            }*/
            if (HasGarageSpace)
            {
                var parkVehicle = Array.IndexOf(_vehicleGarage, null);                                     //find the free parking spot
                if (parkVehicle != -1)
                {
                    _park = true;
                    _vehicleGarage[parkVehicle] = vehicle;                                               //Confirm the spot park the vehicle
                    _availableSpaces--;

                }
                else if (parkVehicle == -1)
                {
                    _park = false;
                }
            }

            return _park;
        }


        public bool RemoveVehicle(T vehicle)                                                                //vehicle can 'Leave' the garage
        {
            _remove = false;
            ArgumentNullException.ThrowIfNull(_vehicleGarage);

            if (_availableSpaces == _parkingSpaces)                                                         //returning a false if the garage is empty and a car is tried to be unparked
            {
                _remove = false;
            }
            if (HasGarageSpace)
            {
                var removeVehicle = Array.IndexOf(_vehicleGarage, vehicle);                                   //find the parking space in the source array of the vehicle to be removed
                var updateGarage = new T[_vehicleGarage.Length];                                              //Create a new array to copy the remaining cars to  

                for (int i = 0; i < _vehicleGarage.Length; i++)                                               // start the garage exit
                {
                    if (i == removeVehicle)                                                                   //Search for the car. when found "unpark"
                    {
                        _vehicleGarage[i] = default(T)!;
                        _availableSpaces++;
                        _remove = true;
                    }
                    /*else
                    {
                        _remove = true;
                        //updateGarage[i] = _vehicleGarage[i];
                    }*/
                }

            }

            PayParking(vehicle);
            Console.ResetColor();
            return _remove;
        }





        /*public bool Unpark(string regnr)
        {
            for (var i = 0; i < spaces.Length; i++)
            {
                if (spaces[i] != null && spaces[i].RegNr.ToLower() == regnr.ToLower())
                {
                    spaces[i] = default(T)!;// null;  // här körs fordonet ut
                    current--;
                    return true;
                }
            }
            return false;
        }*/


        public static bool PayParking(T vehicle)
        {
            Console.WriteLine($"\n{vehicle._vehicleRegistrationNumber} has paid the parking charge and left the Garage");
            return true;
        }



        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _vehicleGarage)
            {
                
            yield return item;
            }
        }


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();






    }

   /* internal class Employee : Object
    {
        public string Name { get; }
        public uint Salary { get; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //{
        //    get
        //    {
        //        if(Salary< 25000)
        //        {
        //            return SalaryLevel.Junior;
        //        }
        //        else
        //        {
        //            return SalaryLevel.Senior;
        //        }
        //    }
        //}

        public Employee(string name, uint salary)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Salary = salary;
        }

        //public string Print()
        //{
        //    return $"Name: {Name} Salary: {Salary} SalaryLevel: {SalaryLevel}";
        //}

        public override string ToString() => $"Name: {Name} Salary: {Salary} SalaryLevel: {SalaryLevel} {base.ToString()}";
    }*/


}
