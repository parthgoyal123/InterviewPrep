using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot.ParkingSpots
{
    public class ParkingSpotTwoWheeler : ParkingSpot
    {
        // Set Constant Price of 10 for Two Wheeler
        private new const int Price = 10;

        public ParkingSpotTwoWheeler() : base(Price)
        {
        }
    }
}
