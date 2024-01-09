﻿namespace RomanNumerals;

public class Converter
{
    public string Convert(int number)
    {
        var numberOfThousands = NumberOfThousands(number);
        var thousands = new string('M', numberOfThousands);
        var adjustedNumber = number - numberOfThousands * 1000;

        var unitDigit = HandleUnitDigit(adjustedNumber, out var ones);
        adjustedNumber -= unitDigit;
        var tens = HandleTensDigit(adjustedNumber, out var ten);
        adjustedNumber -= tens;

        return thousands + ten + ones;
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
    /// Converts the unit digit to roman digits and returns the value of the roman digits
    /// </summary>
    /// <param name="number">The unadjusted number</param>
    /// <param name="romanDigitCharacters">The roman digit that represent the unit digit</param>
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

    private int NumberOfThousands(int number)
    {
        return number / 1000;
    }
}
