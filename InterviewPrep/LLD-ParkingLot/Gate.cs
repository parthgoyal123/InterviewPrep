using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot
{
    public class Gate
    {
        public KeyValuePair<int, int> Coordinates;

        public Gate(KeyValuePair<int, int> location)
        {
            Coordinates = location;
        }

        public KeyValuePair<int, int> GetCoordinates()
        {
            return Coordinates;
        }
    }
}
