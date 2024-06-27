namespace LLD_ParkingLot
{
    public class Vehicle
    {
        public string VehicleNumber { get; set; }

        public VehicleType Type { get; set; }

        public Vehicle(string vehicleNumber, VehicleType type)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
        }
    }
}