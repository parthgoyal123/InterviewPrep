
namespace LLD_ElevatorDesign
{
    internal class MaxComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}