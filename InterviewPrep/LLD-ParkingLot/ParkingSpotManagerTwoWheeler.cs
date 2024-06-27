using LLD_ParkingLot.ParkingSpots;
using LLD_ParkingLot.ParkingStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot
{
    public class ParkingSpotManagerTwoWheeler : ParkingSpotManager
    {
        private List<ParkingSpot> parkingSpots;
        private ParkingStrategy parkingStrategy;

        public ParkingSpotManagerTwoWheeler(List<ParkingSpot> list, ParkingStrategy pk) : base(list, pk)
        {
            parkingSpots = list;
            parkingStrategy = pk;
        }

    }
}
