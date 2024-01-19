namespace GameOfLife;

public class CellTests
{
    [Test]
    public void NumberOfLivingNumberOfNeighbours_OneCell_Is0()
    {
        //Arrange
        var sut = new Cell();

        //Act
        var actual = sut.NumberOfLivingNeighbours;

        //Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Add_NeighbourAtSouth_ThisIsAtNorth()
    {
        //Arrange
        var sut = new Cell();
        var neighbour = new Cell();

        //Act
        sut.Add(Position.South, neighbour);

        //Assert
        Assert.That(sut.At(Position.South), Is.EqualTo(neighbour));
        Assert.That(neighbour.At(Position.North), Is.EqualTo(sut));
    }
}