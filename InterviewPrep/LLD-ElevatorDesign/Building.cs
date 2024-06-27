using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_ElevatorDesign
{
    internal class Building
    {
        private List<Floor> floors;

        public Building(int numFloors)
        {
            floors = new List<Floor>();
            for (int i = 0; i < numFloors; i++)
            {
                floors.Add(new Floor(i));
            }
        }

        public Floor GetFloor(int floorNumber)
        {
            return floors[floorNumber];
        }

        public List<Floor> GetFloors()
        {
            return floors;
        }

        public int GetNumFloors()
        {
            return floors.Count;
        }

        public void AddFloor(Floor floor)
        {
            floors.Add(floor);
        }

        public void RemoveFloor(Floor floor)
        {
            floors.Remove(floor);
        }
    }
}
