namespace LLD_ElevatorDesign
{
    internal class InternalButton
    {
        InternalDispatcher dispatcher = new InternalDispatcher();

        int[] availableButtons = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void PressButton(int destination, ElevatorCar car)
        {
            // Checks if the destination is valid
            if (destination < 1 || destination > 10)
            {
                Console.WriteLine("Invalid destination");
                return;
            }

            // Checks if the elevator is already at the destination
            if (car.GetFloor() == destination)
            {
                Console.WriteLine("Elevator is already at the destination");
                return;
            }

            dispatcher.DispatchElevator(car, destination);
        }
    }
}