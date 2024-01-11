namespace FizzBuzz;

internal class BuzzerTests
{
    [TestCaseSource(typeof(TestData), nameof(TestData.BuzzData))]
    public string Scramble_Value_ReturnsFizzIfDivisbleByThree(int value)
    {
        //Act
        return new Buzzer().Scramble(value);
    }
    private static class TestData
    {
        public static IEnumerable<TestCaseData> BuzzData
        {
            get
            {
                yield return new TestCaseData(1).Returns("1").SetName("1 => 1");
                yield return new TestCaseData(2).Returns("2").SetName("2 => 2");
                yield return new TestCaseData(3).Returns("3").SetName("3 => 3");
                yield return new TestCaseData(4).Returns("4").SetName("4 => 4");
                yield return new TestCaseData(5).Returns("Buzz").SetName("5 => Buzz");
                yield return new TestCaseData(6).Returns("6").SetName("6 => 6");
                yield return new TestCaseData(7).Returns("7").SetName("7 => 7");
                yield return new TestCaseData(8).Returns("8").SetName("8 => 8");
                yield return new TestCaseData(9).Returns("9").SetName("9 => 9");
                yield return new TestCaseData(10).Returns("Buzz").SetName("10 => Buzz");
                yield return new TestCaseData(11).Returns("11").SetName("11 => 11");
                yield return new TestCaseData(12).Returns("12").SetName("12 => 12");
                yield return new TestCaseData(13).Returns("13").SetName("13 => 13");
                yield return new TestCaseData(14).Returns("14").SetName("14 => 14");
                yield return new TestCaseData(15).Returns("Buzz").SetName("15 => Buzz");
                yield return new TestCaseData(16).Returns("16").SetName("16 => 16");
                yield return new TestCaseData(17).Returns("17").SetName("17 => 17");
                yield return new TestCaseData(18).Returns("18").SetName("18 => 18");
                yield return new TestCaseData(19).Returns("19").SetName("19 => 19");
                yield return new TestCaseData(20).Returns("Buzz").SetName("20 => Buzz");
                yield return new TestCaseData(21).Returns("21").SetName("21 => 21");
                yield return new TestCaseData(22).Returns("22").SetName("22 => 22");
                yield return new TestCaseData(23).Returns("23").SetName("23 => 23");
                yield return new TestCaseData(24).Returns("24").SetName("24 => 24");
                yield return new TestCaseData(25).Returns("Buzz").SetName("25 => Buzz");
                yield return new TestCaseData(26).Returns("26").SetName("26 => 26");
                yield return new TestCaseData(27).Returns("27").SetName("27 => 27");
                yield return new TestCaseData(28).Returns("28").SetName("28 => 28");
                yield return new TestCaseData(29).Returns("29").SetName("29 => 29");
                yield return new TestCaseData(30).Returns("Buzz").SetName("30 => Buzz");
            }
        }
    }
}
