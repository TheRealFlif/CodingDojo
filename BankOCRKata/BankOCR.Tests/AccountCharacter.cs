namespace BankOCR;

public class AccountCharacterTests
{
    [Test]
    public void Zero_ReturnsCorrectString()
    {
        //Arrange
        var sut = AccountCharacter.Zero();
        System.Diagnostics.Debug.WriteLine(sut.ToString());

        //Assert
        Assert.That(sut.ToString(), Is.EqualTo(" _ \n| |\n|_|"));
    }
}