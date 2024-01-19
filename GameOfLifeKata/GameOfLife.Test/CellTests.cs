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
}