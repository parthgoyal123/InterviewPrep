using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ElevatorDesign
{
    internal class ElevatorCar
    {
        private int floor;
        private ElevatorDirection direction;
        private ElevatorStatus status;
        private InternalButton internalButton;
        private ElevatorDoor elevatorDoor;
        private ElevatorDisplay display;
        private int id;
        private static int elevatorId = 0;

        public ElevatorCar()
        {
            this.id = elevatorId++;
            this.floor = 0;
            this.direction = ElevatorDirection.UP;
            this.status = ElevatorStatus.IDLE;
            this.internalButton = new InternalButton();
            this.elevatorDoor = new ElevatorDoor();
            this.display = new ElevatorDisplay(floor, direction);
        }

        public void ShowDisplay()
        {
            this.display.Display();
        }

        public void SetDisplay()
        {
            this.display.SetDisplay(this.floor, this.direction);
        }

        public int GetFloor()
        {
            return this.floor;
        }

        public ElevatorDirection GetDirection()
        {
            return this.direction;
        }

        public void SetDirection(ElevatorDirection direction)
        {
            this.direction = direction;
        }

        public bool Move(int destinationFloor, ElevatorDirection direction)
        {
            // Keep Moving the elevator until the destination floor is reached and update the floor, display the floor number
            int currentFloor = this.floor;

            if (direction == ElevatorDirection.UP)
            {
                for (int i = currentFloor; i <= destinationFloor; i++)
                {
                    this.floor = i;
                    SetDisplay();
                    ShowDisplay();

                    if (i == destinationFloor)
                    {
                        return true;

                    }
                }
            }
            else if (direction == ElevatorDirection.DOWN)
            {
                for (int i = currentFloor; i >= destinationFloor; i--)
                {
                    this.floor = i;
                    SetDisplay();
                    ShowDisplay();

                    if (i == destinationFloor)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Reset()
        {
            this.direction = ElevatorDirection.NONE;
            this.status = ElevatorStatus.IDLE;
        }
    }
}
