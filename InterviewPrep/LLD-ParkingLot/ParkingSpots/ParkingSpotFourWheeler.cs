using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot.ParkingSpots
{
    public class ParkingSpotFourWheeler : ParkingSpot
    {
        private new const int Price = 20;

        public ParkingSpotFourWheeler() : base(Price)
        {
        }
    }
}
