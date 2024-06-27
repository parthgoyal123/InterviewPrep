using LLD_ParkingLot.ParkingSpots;
using LLD_ParkingLot.ParkingStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot
{
    public class ParkingSpotManager
    {
        private List<ParkingSpot> spotList;
        private ParkingStrategy parkingStrategy;

        public ParkingSpotManager(List<ParkingSpot> list, ParkingStrategy parkingStrategy)
        {
            this.spotList = list;
            this.parkingStrategy = parkingStrategy;
        }

        public void AddSpot(ParkingSpot spot)
        {
            spotList.Add(spot);
        }

        public void RemoveSpot(ParkingSpot spot)
        {
            // Remove if spot is present in the list
            if (spotList.Contains(spot))
            {
                spotList.Remove(spot);
            }
        }

        // Park Vehicle
        public void ParkVehicle(Vehicle vehicle)
        {
            ParkingSpot spot = this.parkingStrategy.GetAvailableSpot(this.spotList);
            if (spot == null)
            {
                throw new Exception("No spot available");
            }
            spot.ParkVehicle(vehicle);
        }

        // Remove Vehicle
        public void RemoveVehicle(Vehicle vehicle)
        {
            foreach (ParkingSpot spot in spotList)
            {
                if (spot.Vehicle == vehicle)
                {
                    spot.RemoveVehicle();
                    return;
                }
            }
        }
    }
}
