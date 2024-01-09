namespace RomanNumerals;

public class Converter
{
    public string Convert(int number)
    {
        var adjustedNumber = number;
        var unitDigit = HandleUnitDigit(adjustedNumber, out var one);
        adjustedNumber -= unitDigit;
        var tens = HandleTensDigit(adjustedNumber, out var ten);
        adjustedNumber -= tens;
        var hundreds = HandleHundredsDigit(adjustedNumber, out var hundred);
        adjustedNumber -= hundreds;
        var thousands = HandleThousandsDigit(adjustedNumber, out var thousand);
        adjustedNumber -= thousands;

        return thousand + hundred + ten + one;
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

    /// <summary>
    /// Converts the ten digit to roman digits and returns the value of the roman digits
    /// </summary>
    /// <param name="number">The unadjusted number</param>
    /// <param name="romanDigitCharacters">The roman digit that represent the ten digit</param>
    /// <returns>The value of the roman digits</returns>
    private int HandleTensDigit(int number, out string romanDigitCharacters)
    {
        var unitDigit = number % 10;
        var tenDigit = (number - unitDigit) % 100;
        romanDigitCharacters = tenDigit switch
        {
            10 => "X",
            20 => "XX",
            30 => "XXX",
            40 => "XL",
            50 => "L",
            60 => "LX",
            70 => "LXX",
            80 => "LXXX",
            90 => "XC",
            _ => ""
        };

        return tenDigit;
    }

    /// <summary>
    /// Converts the hundred digit to roman digits and returns the value of the roman digits
    /// </summary>
    /// <param name="number">The unadjusted number</param>
    /// <param name="romanDigitCharacters">The roman digit that represent the hundred digit</param>
    /// <returns>The value of the roman digits</returns>
    private int HandleHundredsDigit(int number, out string romanDigitCharacters)
    {
        var unitDigit = number % 10;
        var tenDigit = (number - unitDigit) % 100;
        var hundredDigit = (number - unitDigit-tenDigit) % 1000;
        romanDigitCharacters = hundredDigit switch
        {
            100 => "C",
            200 => "CC",
            300 => "CCC",
            400 => "CD",
            500 => "D",
            600 => "DC",
            700 => "DCC",
            800 => "DCCC",
            900 => "CM",
            _ => ""
        };

        return hundredDigit;
    }

    /// <summary>
    /// Converts the thousands digit to roman digits and returns the value of the roman digits
    /// </summary>
    /// <param name="number">The unadjusted number</param>
    /// <param name="romanDigitCharacters">The roman digit that represent the thounsand digit</param>
    /// <returns>The value of the roman digits</returns>
    private int HandleThousandsDigit(int number, out string romanDigitCharacters)
    {
        var unitDigit = number % 10;
        var tenDigit = (number - unitDigit) % 100;
        var hundredDigit = (number - unitDigit - tenDigit) % 1000;
        var returnValue = (number - unitDigit - tenDigit - hundredDigit) / 1000;

        romanDigitCharacters = new string('M', returnValue);

        return returnValue;
    }
}
