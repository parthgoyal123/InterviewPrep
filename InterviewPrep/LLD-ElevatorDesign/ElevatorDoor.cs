namespace LLD_ElevatorDesign
{
    internal class ElevatorDoor
    {
        private bool _isOpen;

        public ElevatorDoor()
        {
            _isOpen = false;
        }

        public void Open()
        {
            _isOpen = true;
        }

        public void Close()
        {
            _isOpen = false;
        }

        public bool IsOpen()
        {
            return _isOpen;
        }
    }
}