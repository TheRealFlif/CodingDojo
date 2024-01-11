namespace BankOCR;

public class AccountLineTests
{
    [Test]
    public void AddCharachter_()
    {
        //Arrange
        var sut = new AccountLine();
        sut.AddCharachter(1);
        sut.AddCharachter(2);
        sut.AddCharachter(3);
        sut.AddCharachter(4);
        sut.AddCharachter(5);
        sut.AddCharachter(6);
        sut.AddCharachter(7);
        sut.AddCharachter(8);
        sut.AddCharachter(9);

        //Act
        System.Diagnostics.Debug.WriteLine(sut.ToString());

        //Assert
    }
}