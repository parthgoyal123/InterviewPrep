using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot.ParkingSpots
{
    public class ParkingSpot
    {
        public int Id { get; set; }

        public bool IsOccupied { get; set; }

        public Vehicle Vehicle { get; set; }

        public int Price { get; set; }

        public KeyValuePair<int, int> Coordinates { get; set; }

        public ParkingSpot(int price)
        {
            Price = price;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            // Check if the spot is already occupied and vehicle is not null
            if (IsOccupied || vehicle == null)
            {
                throw new Exception("Parking spot is already occupied or vehicle is null");
            }

            Vehicle = vehicle;
            IsOccupied = true;
        }

        public void RemoveVehicle()
        {
            // Check if the spot is already empty
            if (!IsOccupied)
            {
                throw new Exception("Parking spot is already empty");
            }

            Vehicle = null;
            IsOccupied = false;
        }
    }
}
