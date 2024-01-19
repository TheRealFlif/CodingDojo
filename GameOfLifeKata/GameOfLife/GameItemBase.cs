namespace GameOfLife
{
    public abstract class GameItemBase : IGameItem
    {
        private readonly Dictionary<Position, IGameItem> _items = new Dictionary<Position, IGameItem>();

        protected GameItemBase()
        {
            for (int i = 1; i < (int)Position.NorthWest + 1; i++)
            {
                _items.Add((Position)i, null);
            }
        }

        public virtual void Connect(Position position, IGameItem item)
        {
            if (item == null)
            {
                return;
            }

            if (At(position) != null && At(position) != item)
            {
                throw new Exception($"Det finns redan ett item på position '{position}'");
            }

            if (At(position) == null)
            {
                _items[position] = item;
                item.Connect(Invert(position), this);
            }
        }

        public IGameItem At(Position position)
        {
            return _items[position];
        }

        protected static Position Invert(Position position)
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
}
