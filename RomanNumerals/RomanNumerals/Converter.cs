namespace RomanNumerals;

public class Converter
{
    public string Convert(int number)
    {
        var numberOfThousands = NumberOfThousands(number);
        var thousands = new string('M', numberOfThousands);
        var adjustedNumber = number - numberOfThousands * 1000;

        var five = string.Empty;
        if (adjustedNumber > 3 && adjustedNumber < 9)
        {
            switch (adjustedNumber)
            {
                case 4:
                    five = "IV";
                    adjustedNumber = 0;
                    break;

                default:
                    five = "V";
                    adjustedNumber -= 5;
                    break;
            }
        }

        var numberOfOnes = NumberOfOnes(adjustedNumber);
        var ones = new string('I', numberOfOnes);

        return thousands + five + ones;
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
