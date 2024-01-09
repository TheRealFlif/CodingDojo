namespace RomanNumerals;

[TestFixture]
public class RomanNumeralConverterTest
{
    [Test]
    public void Convert_StringEmpty_Returns0()
    {
        //Arrange
        var romanNumeral = string.Empty;
        var sut = new RomanNumeralConverter();

        //Act
        var actual = sut.Convert(romanNumeral);

        //Assert
        Assert.That(actual, Is.EqualTo(0));
    }
}

[TestFixture]
public class BrutalNumeralConverterTest
{
    [TestCaseSource(typeof(TestData), nameof(TestData.RomanNumerals))]
    public int Convert(string romanNumeral)
    {
        return new BrutalRomanNumeralConverter().Convert(romanNumeral);
    }


    private static class TestData
    {
        public static IEnumerable<TestCaseData> RomanNumerals
        {
            get
            {
                //yield return new TestCaseData("ABC").Returns(0).SetName("ABC -> 0");
                yield return new TestCaseData("I").Returns(1).SetName("I -> 1");
                yield return new TestCaseData("II").Returns(2).SetName("II -> 2");
                yield return new TestCaseData("III").Returns(3).SetName("III -> 3");
                yield return new TestCaseData("IV").Returns(4).SetName("IV -> 4");
                yield return new TestCaseData("V").Returns(5).SetName("V -> 5");
                yield return new TestCaseData("VI").Returns(6).SetName("VI -> 6");
                yield return new TestCaseData("VII").Returns(7).SetName("VII -> 7");
                yield return new TestCaseData("VIII").Returns(8).SetName("VIII -> 8");
                yield return new TestCaseData("IX").Returns(9).SetName("IX -> 9");
                yield return new TestCaseData("X").Returns(10).SetName("X -> 10");
                yield return new TestCaseData("XI").Returns(11).SetName("XI -> 11");
                yield return new TestCaseData("XII").Returns(12).SetName("XII -> 12");
                yield return new TestCaseData("XIII").Returns(13).SetName("XIII -> 13");
                yield return new TestCaseData("XIV").Returns(14).SetName("XIV -> 14");
                yield return new TestCaseData("XV").Returns(15).SetName("XV -> 15");
                yield return new TestCaseData("XVI").Returns(16).SetName("XVI -> 16");
                yield return new TestCaseData("XVII").Returns(17).SetName("XVII -> 17");
                yield return new TestCaseData("XVIII").Returns(18).SetName("XVIII -> 18");
                yield return new TestCaseData("XIX").Returns(19).SetName("XIX -> 19");
                yield return new TestCaseData("XX").Returns(20).SetName("XX -> 20");
                yield return new TestCaseData("XXI").Returns(21).SetName("XXI -> 21");
                yield return new TestCaseData("XXII").Returns(22).SetName("XXII -> 22");
                yield return new TestCaseData("XXIII").Returns(23).SetName("XXIII -> 23");
                yield return new TestCaseData("XXIV").Returns(24).SetName("XXIV -> 24");
                yield return new TestCaseData("XXV").Returns(25).SetName("XXV -> 25");
                yield return new TestCaseData("XXVI").Returns(26).SetName("XXVI -> 26");
                yield return new TestCaseData("XXVII").Returns(27).SetName("XXVII -> 27");
                yield return new TestCaseData("XXVIII").Returns(28).SetName("XXVIII -> 28");
                yield return new TestCaseData("XXIX").Returns(29).SetName("XXIX -> 29");
                yield return new TestCaseData("XXX").Returns(30).SetName("XXX -> 30");

                yield return new TestCaseData("XL").Returns(40).SetName("XL -> 40");
                yield return new TestCaseData("L").Returns(50).SetName("L -> 50");
                yield return new TestCaseData("LX").Returns(60).SetName("LX -> 60");
                yield return new TestCaseData("LXX").Returns(70).SetName("LXX -> 70");
                yield return new TestCaseData("LXXX").Returns(80).SetName("LXXX -> 80");
                yield return new TestCaseData("XC").Returns(90).SetName("XC -> 90");

                yield return new TestCaseData("C").Returns(100).SetName("C -> 100");
                yield return new TestCaseData("CC").Returns(200).SetName("CC -> 200");
                yield return new TestCaseData("CCC").Returns(300).SetName("CCC -> 300");
                yield return new TestCaseData("CD").Returns(400).SetName("CD -> 400");
                yield return new TestCaseData("D").Returns(500).SetName("D -> 500");
                yield return new TestCaseData("DC").Returns(600).SetName("DC -> 600");
                yield return new TestCaseData("DCC").Returns(700).SetName("DCC -> 700");
                yield return new TestCaseData("DCCC").Returns(800).SetName("DCCC -> 800");
                yield return new TestCaseData("CM").Returns(900).SetName("CM -> 900");

                yield return new TestCaseData("M").Returns(1000).SetName("M -> 1000");
                yield return new TestCaseData("MM").Returns(2000).SetName("MM -> 2000");
                yield return new TestCaseData("MMM").Returns(3000).SetName("MMM -> 3000");
                yield return new TestCaseData("MMMM").Returns(4000).SetName("MMMM -> 4000");

                yield return new TestCaseData("MMMMCDXLIV").Returns(4444).SetName("MMMMCDXLIV -> 4444");
            }
        }
    }
}