namespace LLD_ElevatorDesign
{
    internal class ElevatorController
    {
        private ElevatorCar elevatorCar;
        private PriorityQueue<int, int> upMinPQ;
        private PriorityQueue<int, int> downMaxPQ;
        private List<int> pendingJobs;

        public ElevatorController(ElevatorCar elevatorCar)
        {
            this.elevatorCar = elevatorCar;
            upMinPQ = new PriorityQueue<int, int>();

            downMaxPQ = new PriorityQueue<int, int>(new MaxComparer());
            pendingJobs = new List<int>();
        }
        
        public void SubmitExternalRequest(int floorNumber, ElevatorDirection direction)
        {
            if (direction == ElevatorDirection.UP)
            {
                upMinPQ.Enqueue(floorNumber, floorNumber);
            }
            else
            {
                downMaxPQ.Enqueue(floorNumber, floorNumber);
            }
        }

        public void SubmitInternalRequest(int floorNumber)
        {
        }

        public void ControlElevator()
        {
            while(true)
            {
                // "LOOK" Elevator Algorithm
            }
        }

    }
}