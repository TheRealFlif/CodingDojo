using System.Text;

namespace BankOCR;

public class AccountLineTests
{
    [Test]
    public void AddCharacter_()
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

    [Test]
    public void ToIntegers_OnlyOnes_Returns111111111()
    {
        //Arrange
        var oneRows = AccountCharacter.StringForNumber[1];
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(string.Join("", Enumerable.Repeat(oneRows[0], 9)));
        stringBuilder.AppendLine(string.Join("", Enumerable.Repeat(oneRows[1], 9)));
        stringBuilder.AppendLine(string.Join("", Enumerable.Repeat(oneRows[2], 9)));
        var sut = AccountLine.Create(stringBuilder.ToString());

        //Act
        var actual = sut.ToIntegers();

        //Assert
        Assert.That(actual.Count, Is.EqualTo(9));
        Assert.That(actual.All(i => i == 1), Is.True);
        
    }
}
