
namespace LLD_ElevatorDesign
{
    internal class ElevatorDisplay
    {
        private int floor;
        private ElevatorDirection direction;

        public ElevatorDisplay(int floor, ElevatorDirection direction)
        {
            this.floor = floor;
            this.direction = direction;
        }

        public void SetFloor(int floor)
        {
            this.floor = floor;
        }

        public void SetDirection(ElevatorDirection direction)
        {
            this.direction = direction;
        }

        public int GetFloor()
        {
            return floor;
        }

        public ElevatorDirection GetDirection()
        {
            return direction;
        }

        public void Display()
        {
            // Display the floor number and direction
            Console.WriteLine("Floor: " + floor + " Direction: " + direction.ToString());
        }

        internal void SetDisplay(int floor, ElevatorDirection direction)
        {
            this.floor = floor;
            this.direction = direction;
        }
    }
}