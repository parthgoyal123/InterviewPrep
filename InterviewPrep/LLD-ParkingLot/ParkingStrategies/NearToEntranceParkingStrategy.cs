using LLD_ParkingLot.ParkingSpots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ParkingLot.ParkingStrategies
{
    public class NearToEntranceParkingStrategy : ParkingStrategy
    {
        public override ParkingSpot GetAvailableSpot(List<ParkingSpot> spotList, List<Gate> gates)
        {
            ParkingSpot nearestSpot = null;
            int minDistance = int.MaxValue;
            foreach (ParkingSpot spot in spotList)
            {
                if (!spot.IsOccupied)
                {
                    foreach (var gate in gates)
                    {
                        int distance = CalculateDistance(spot.Coordinates, gate.GetCoordinates());
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            nearestSpot = spot;
                        }
                    }
                }
            }
            return nearestSpot;
        }

        private int CalculateDistance(KeyValuePair<int, int> coordinates, KeyValuePair<int, int> keyValuePair)
        {
            return Math.Abs(coordinates.Key - keyValuePair.Key) + Math.Abs(coordinates.Value - keyValuePair.Value);
        }
    }
}
