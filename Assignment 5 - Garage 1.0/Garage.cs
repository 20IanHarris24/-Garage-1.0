using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    
    public class Garage <T> where T : class
    {

        private List<T> _list;                                              //creating a limited list to simulate the garage.
        private readonly int _parkingSpaces;

        public int Check => _list.Count;
        public bool GarageIsFull => _parkingSpaces <= Check;
        public bool GarageIsEmpty => _parkingSpaces == Check;

        
        
        public Garage(int totalSpaces) 
        {
            _parkingSpaces = Math.Max(totalSpaces, 2);
            _list = new List<T>(_parkingSpaces);
        }

        public bool ParkCar(T item)                                         //vehicle can 'Park' in the garage
        {
            bool confirm;
            ArgumentNullException.ThrowIfNull(item, "item");
            
            if(GarageIsFull) confirm = false;    
            _list.Add(item); confirm = true;
            
            return confirm;
        }


        public bool RemoveCar(T item)
        {
            bool confirm;
            ArgumentNullException.ThrowIfNull(item, "item");

            if (GarageIsEmpty) confirm = false;
            _list.Remove(item); confirm = true;

            return confirm;
        }

    
    
    
    
    
    
    
    }




}
