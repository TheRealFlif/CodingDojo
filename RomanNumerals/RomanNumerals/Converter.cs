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

        var numberOfOnes = NumberOfOnes(adjustedNumber);
        var ones = new string('I', numberOfOnes);

        return thousands + fifties + ten + five + ones;
    }

    private int NumberOfOnes(int number)
    {
        return number > 3 ? 0 : number;
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
