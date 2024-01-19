public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            throw new ArgumentException($"Parametrar måste vara positiva, var ('{x}', '{y}'");
        }
        X = x;
        Y = y;
    }
}

