using GameOfLife;
using System.Text;

public class Game
{
    private IGameItem[,] _board;

    public int Width { get; }
    public int Height { get; }

    public Game(int width, int height, IEnumerable<Coordinate> coordinates)
    {
        Width = width + 2;
        Height = height + 2;
        var legitCoordinates = coordinates?.Where(c => c.X < width + 1 && c.Y < height + 1) ?? Enumerable.Empty<Coordinate>();

        _board = new IGameItem[Width, Height];
        _board[0, 0] = new Corner();
        _board[0, Height-1] = new Corner();
        _board[Width-1, Height-1] = new Corner();
        _board[Width-1, 0] = new Corner();

        for (int x = 1; x < Width-1; x++)
        {
            _board[x, 0] = new Wall();
            _board[x, Height-1] = new Wall();
        }

        for (int y = 1; y < Height-1; y++)
        {
            _board[0, y] = new Wall();
            _board[Width-1, y] = new Wall();
        }

        for (int x = 1; x < Width; x++)
        {
            _board[x, 0].Connect(Position.West, _board[x - 1, 0]);
            _board[x, Height-1].Connect(Position.West, _board[x - 1, Height-1]);
        }

        for (int y = 1; y < Height; y++)
        {
            _board[0, y].Connect(Position.South, _board[0, y - 1]);
            _board[Width-1, y].Connect(Position.South, _board[Width-1, y - 1]);
        }
    }

    public string ToString()
    {
        var stringBuilder = new StringBuilder();
        for (int y = Height-1; y >= 0; y--)
        {
            for (int x = 0; x < Width; x++)
            {
                var character = " ";
                if (_board[x, y] is Wall)
                {
                    character = "+";
                }

                if (_board[x, y] is Corner)
                {
                    character = "o";
                }

                stringBuilder.Append(character);
            }
            stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }
}

