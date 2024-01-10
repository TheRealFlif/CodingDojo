namespace FizzBuzz.Test;

public class FizzerTests
{
    
    [TestCaseSource(typeof(TestData), nameof(TestData.FizzData))]
    public string Scramble_Value_ReturnsFizzIfDivisbleByThree(int value)
    {
        //Act
        return new Fizzer().Scramble(value);
    }
    private static class TestData
    {
        public static IEnumerable<TestCaseData> FizzData { get
            {
                yield return new TestCaseData(1).Returns("1").SetName("1 => 1");
                yield return new TestCaseData(2).Returns("2").SetName("2 => 2");
                yield return new TestCaseData(3).Returns("Fizz").SetName("3 => Fizz");
                yield return new TestCaseData(4).Returns("4").SetName("4 => 4");
                yield return new TestCaseData(5).Returns("5").SetName("5 => 5");
                yield return new TestCaseData(6).Returns("Fizz").SetName("6 => Fizz");
                yield return new TestCaseData(7).Returns("7").SetName("7 => 7");
                yield return new TestCaseData(8).Returns("8").SetName("8 => 8");
                yield return new TestCaseData(9).Returns("Fizz").SetName("9 => Fizz");
                yield return new TestCaseData(10).Returns("10").SetName("10 => 10");
                yield return new TestCaseData(11).Returns("11").SetName("11 => 11");
                yield return new TestCaseData(12).Returns("Fizz").SetName("12 => Fizz");
            } 
        }
    }
}


