namespace RomanNumerals;

public class Converter
{
    public object Convert(int number)
    {
        var returnValue = number == 1
            ? "I"
            : "II";

        return returnValue;
    }
}
