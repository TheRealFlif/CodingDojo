namespace RomanNumerals;

public class Converter
{
    public string Convert(int number)
    {
        var numberOfThousands = NumberOfThousands(number);
        var thousands = new string('M', numberOfThousands);
        var adjustedNumber = number - numberOfThousands * 1000;

        var numberOfOnes = NumberOfOnes(adjustedNumber);
        var ones = new string('I', numberOfOnes);
        
        return thousands + ones;
    }

    private int NumberOfOnes(int number)
    {
        return number > 3 ? 0 : number;
    }

    private int NumberOfThousands(int number)
    {
        return number / 1000;
    }
}
