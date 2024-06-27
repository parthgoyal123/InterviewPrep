namespace LLD_ElevatorDesign
{
    internal class Floor
    {
        private int floorNumber;

        private ExternalDispatcher externalDispatcher;

        public Floor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            externalDispatcher = new ExternalDispatcher();
        }

        public void RequestElevator(ElevatorDirection direction)
        {
            externalDispatcher.DispatchElevator(floorNumber, direction);
        }
    }
}