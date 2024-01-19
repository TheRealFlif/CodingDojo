namespace GameOfLife;

public class Cell : IGameItem
{
    private readonly Dictionary<Position, IGameItem> _items = new Dictionary<Position, IGameItem>();

    public Cell()
    {
        for(int i=1; i< (int)Position.NorthWest+1; i++)
        {
            _items.Add((Position)i, null);
        }
    }

    public int NumberOfLivingNeighbours { get; }

    public void Add(Position position, IGameItem item)
    {
        if (_items[position] != null && _items[position] != item)
        {
            throw new Exception($"Det finns redan ett item på position '{position}'");
        }

        if (_items[position] == null)
        {
            _items.Add(position, item);
            if (item is Cell cell)
            {
                cell.Add(Invert(position), item);
            }
        }
    }

    public IGameItem At(Position position)
    {
        return _items[position];
    }

    private static Position Invert(Position position)
    {
        var lookup = new Dictionary<Position, Position>()
        {
            { Position.North, Position.South},
            { Position.NorthEast, Position.SouthWest},
            { Position.East, Position.West},
            { Position.SouthEast, Position.NorthWest},
            { Position.South, Position.North},
            { Position.SouthWest, Position.NorthEast},
            { Position.West, Position.East},
            { Position.NorthWest, Position.SouthEast}
        };

        return lookup[position];
    }
}
