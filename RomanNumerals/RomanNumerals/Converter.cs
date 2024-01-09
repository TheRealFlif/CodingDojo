namespace RomanNumerals;

public class Converter
{
    public string Convert(int number)
    {
        var numberOfThousands = NumberOfThousands(number);
        var thousands = new string('M', numberOfThousands);
        var adjustedNumber = number - numberOfThousands * 1000;

        var fifties = string.Empty;
        if (adjustedNumber >= 19 && adjustedNumber < 40)
        {
            var numberOfTens = NumberOfTens(adjustedNumber);
            fifties = new string('X', numberOfTens);
            adjustedNumber -= numberOfTens * 10;
        }



        var ten = string.Empty;
        if(adjustedNumber >= 9 && adjustedNumber <=18) {
            switch(adjustedNumber )
            {
                case 9:
                    ten = "IX";
                    adjustedNumber = 0;
                    break;

                default:
                    ten = "X";
                    adjustedNumber -= 10;
                    break;
            }
        }

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

        _ = HandleUnitDigit(adjustedNumber, out var ones);

        return thousands + fifties + ten + five + ones;
    }

    /// <summary>
    /// Converts the unit digit to roman digits and returns the value of the roman digits
    /// </summary>
    /// <param name="number">The unadjusted number</param>
    /// <param name="romanDigitCharacters">The roman digit that represent the unit digit</param>
    /// <returns>The value of the roman digits</returns>
    private int HandleUnitDigit(int number, out string romanDigitCharacters)
    {
        var unitDigit = number % 10;
        romanDigitCharacters = unitDigit switch
        { 
            1 => "I",
            2 => "II",
            3 => "III",
            4 => "IV",
            5 => "V",
            6 => "VI",
            7 => "VII",
            8 => "VIII",
            9 => "IX",
            _ => ""
        };

        return unitDigit;
    }

    private int NumberOfTens(int number)
    {
        return number / 10;
    }

    private int NumberOfThousands(int number)
    {
        return number / 1000;
    }
}
