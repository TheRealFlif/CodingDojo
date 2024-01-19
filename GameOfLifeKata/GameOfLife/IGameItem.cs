namespace GameOfLife;

public interface IGameItem
{
    void Connect(Position position, IGameItem item);
}
