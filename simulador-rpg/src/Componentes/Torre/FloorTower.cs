public class FloorTower
{
    private string FloorName;
    private int FloorNumber;

    public FloorTower(string na, int nu)
    {
        FloorName = na;
        FloorNumber = nu;
    }

    public string getFloorName()
    {
        return FloorName;
    }
    public int getFloorNumber()
    {
        return FloorNumber;
    }
}