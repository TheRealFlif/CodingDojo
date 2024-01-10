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
            } 
        }
    }
}


