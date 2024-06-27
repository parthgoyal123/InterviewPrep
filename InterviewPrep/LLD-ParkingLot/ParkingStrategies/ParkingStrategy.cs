using LLD_ParkingLot.ParkingSpots;

namespace LLD_ParkingLot.ParkingStrategies
{
    public abstract class ParkingStrategy
    {
        public abstract ParkingSpot GetAvailableSpot(List<ParkingSpot> spotList, Gate gate);
    }
}