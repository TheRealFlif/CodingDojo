namespace GameOfLife;

internal class GameTests
{
    [Test]
    public void Game_1_1_()
    {
        //Arrange
        var sut = new Game(1, 1, Enumerable.Empty<Coordinate>());

        //Act
        var actual = sut.ToString();
        System.Diagnostics.Debug.Write(actual);
    }

    [Test]
    public void Game_2_2_()
    {
        //Arrange
        var sut = new Game(2, 2, Enumerable.Empty<Coordinate>());

        //Act
        var actual = sut.ToString();
        System.Diagnostics.Debug.Write(actual);
    }

    [Test]
    public void Game_10_10_()
    {
        //Arrange
        var sut = new Game(10, 10, Enumerable.Empty<Coordinate>());

        //Act
        var actual = sut.ToString();
        System.Console.WriteLine(actual);
        System.Diagnostics.Debug.Write(actual);
    }
}
