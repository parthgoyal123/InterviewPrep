using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot
{
    public class EntranceGate : Gate
    {
        public EntranceGate(KeyValuePair<int, int> location) : base(location)
        {
        }
    }
}
