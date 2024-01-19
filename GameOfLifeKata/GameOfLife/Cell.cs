namespace GameOfLife;

public class Cell : GameItemBase
{
    public Cell() :base() { }

    public int NumberOfLivingNeighbours { get; }
}
