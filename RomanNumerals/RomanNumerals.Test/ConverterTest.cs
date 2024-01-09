namespace RomanNumerals;

[TestFixture]
public class ConverterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Convert_1_Returns_I()
    {
        //Arrange
        var sut = new Converter();
        var number = 1;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("I"));
    }

    [Test]
    public void Convert_2_Returns_II()
    {
        //Arrange
        var sut = new Converter();
        var number = 2;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("II"));
    }

    [Test]
    public void Convert_4_Returns_IV()
    {
        //Arrange
        var sut = new Converter();
        var number = 4;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("IV"));
    }

    [Test]
    public void Convert_5_Returns_V()
    {
        //Arrange
        var sut = new Converter();
        var number = 5;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("V"));
    }

    [Test]
    public void Convert_1001_Returns_MI()
    {
        //Arrange
        var sut = new Converter();
        var number = 1001;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("MI"));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.Numbers))]
    public string Convert(int number)
    {
        return new Converter().Convert(number);
    }

    private static class TestData
    {
        public static IEnumerable<TestCaseData> Numbers
        {
            get
            {
                yield return new TestCaseData(1).Returns("I").SetName("1 -> I"); 
                yield return new TestCaseData(2).Returns("II").SetName("2 -> II");
                yield return new TestCaseData(3).Returns("III").SetName("3 -> III");
                yield return new TestCaseData(4).Returns("IV").SetName("4 -> IV");
                yield return new TestCaseData(5).Returns("V").SetName("5 -> V");
                yield return new TestCaseData(6).Returns("VI").SetName("6 -> VI");
                yield return new TestCaseData(7).Returns("VII").SetName("7 -> VII");
                yield return new TestCaseData(8).Returns("VIII").SetName("8 -> VIII");
                yield return new TestCaseData(9).Returns("IX").SetName("9 -> IX");
                yield return new TestCaseData(10).Returns("X").SetName("10 -> X");
                yield return new TestCaseData(11).Returns("XI").SetName("11 -> XI");
                yield return new TestCaseData(12).Returns("XII").SetName("12 -> XII");
                yield return new TestCaseData(13).Returns("XIII").SetName("13 -> XIII");
                yield return new TestCaseData(14).Returns("XIV").SetName("14 -> XIV");
                yield return new TestCaseData(15).Returns("XV").SetName("15 -> XV");
                yield return new TestCaseData(16).Returns("XVI").SetName("16 -> XVI");
                yield return new TestCaseData(17).Returns("XVII").SetName("17 -> XVII");
                yield return new TestCaseData(18).Returns("XVIII").SetName("18 -> XVIII");
                yield return new TestCaseData(19).Returns("XIX").SetName("19 -> XIX");
                yield return new TestCaseData(20).Returns("XX").SetName("20 -> XX");
                yield return new TestCaseData(21).Returns("XXI").SetName("21 -> XXI");
                yield return new TestCaseData(22).Returns("XXII").SetName("22 -> XXII");
                yield return new TestCaseData(23).Returns("XXIII").SetName("23 -> XXIII");
                yield return new TestCaseData(24).Returns("XXIV").SetName("24 -> XXIV");
                yield return new TestCaseData(25).Returns("XXV").SetName("25 -> XXV");
                yield return new TestCaseData(26).Returns("XXVI").SetName("26 -> XXVI");
                yield return new TestCaseData(27).Returns("XXVII").SetName("27 -> XXVII");
                yield return new TestCaseData(28).Returns("XXVIII").SetName("28 -> XXVIII");
                yield return new TestCaseData(29).Returns("XXIX").SetName("29 -> XXIX");
                yield return new TestCaseData(30).Returns("XXX").SetName("30 -> XXX");

                yield return new TestCaseData(40).Returns("XL").SetName("40 -> XL");
                yield return new TestCaseData(50).Returns("L").SetName("50 -> L");
                yield return new TestCaseData(60).Returns("LX").SetName("60 -> LX");
                yield return new TestCaseData(70).Returns("LXX").SetName("70 -> LXX");
                yield return new TestCaseData(80).Returns("LXXX").SetName("80 -> LXXX");
                yield return new TestCaseData(90).Returns("XC").SetName("90 -> XC");

                yield return new TestCaseData(100).Returns("C").SetName("100 -> C");
                yield return new TestCaseData(200).Returns("CC").SetName("200 -> CC");
                yield return new TestCaseData(300).Returns("CCC").SetName("300 -> CCC");
                yield return new TestCaseData(400).Returns("CD").SetName("400 -> CD");
                yield return new TestCaseData(500).Returns("D").SetName("500 -> D");
                yield return new TestCaseData(600).Returns("DC").SetName("600 -> DC");
                yield return new TestCaseData(700).Returns("DCC").SetName("700 -> DCC");
                yield return new TestCaseData(800).Returns("DCCC").SetName("800 -> DCCC");
                yield return new TestCaseData(900).Returns("CM").SetName("900 -> CM");

                yield return new TestCaseData(1000).Returns("M").SetName("1000 -> M");
                yield return new TestCaseData(2000).Returns("MM").SetName("2000 -> MM");
                yield return new TestCaseData(3000).Returns("MMM").SetName("3000 -> MMM");
                yield return new TestCaseData(4000).Returns("MMMM");

                yield return new TestCaseData(4444).Returns("MMMMCDXLIV").SetName("4444 -> MMMMCDXLIV");
            }
        }
    }
}

[TestFixture]
public class RomanNumeraltConverterTest
{
    [Test]
    public void Convert_StringEmpty_Returns0()
    {
        //Arrange
        var romanNumeral = string.Empty;
        var sut = new RomanNumeraltConverter();

        //Act
        var actual = sut.Convert(romanNumeral);

        //Assert
        Assert.That(actual, Is.EqualTo(0));

    }
}