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
                yield return new TestCaseData(13).Returns("Fizz").SetName("13 => Fizz");
                yield return new TestCaseData(14).Returns("14").SetName("14 => 14");
                yield return new TestCaseData(15).Returns("Fizz").SetName("15 => Fizz");
                yield return new TestCaseData(16).Returns("16").SetName("16 => 16");
                yield return new TestCaseData(17).Returns("17").SetName("17 => 17");
                yield return new TestCaseData(18).Returns("Fizz").SetName("18 => Fizz");
                yield return new TestCaseData(19).Returns("19").SetName("19 => 19");
                yield return new TestCaseData(20).Returns("20").SetName("20 => 20");
                yield return new TestCaseData(21).Returns("Fizz").SetName("21 => Fizz");
                yield return new TestCaseData(22).Returns("22").SetName("22 => 22");
                yield return new TestCaseData(23).Returns("Fizz").SetName("23 => Fizz");
                yield return new TestCaseData(24).Returns("Fizz").SetName("24 => Fizz");
                yield return new TestCaseData(25).Returns("25").SetName("25 => 25");
                yield return new TestCaseData(26).Returns("26").SetName("26 => 26");
                yield return new TestCaseData(27).Returns("Fizz").SetName("27 => Fizz");
                yield return new TestCaseData(28).Returns("28").SetName("28 => 28");
                yield return new TestCaseData(29).Returns("29").SetName("29 => 29");
                yield return new TestCaseData(30).Returns("Fizz").SetName("30 => Fizz");
            } 
        }
    }
}


