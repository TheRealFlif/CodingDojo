namespace RomanCalculator;

public class RomanCalculator
{
    public string Add(string operand1, string operand2)
    {
        var romanUnit = AddUnit(operand1, operand2, out var carrieUnit);
        var romanTens = AddTens(operand1, operand2, carrieUnit, out var carrieTen);
        var romanHundreds = string.Empty;
        var romanThousands = string.Empty;
        return $"{romanThousands}{romanHundreds}{romanTens}{romanUnit}";
    }

    private static string AddUnit(
        string operand1, 
        string operand2, 
        out int carrie) 
    {
        var unit1 = GetUnitPart(operand1);
        var unit2 = GetUnitPart(operand2);
        var sum = unit1 + unit2;
        
        carrie = (sum > 9)
            ? 10
            : 0;

        return ConvertUnitToRomanNumeral(sum%10);
    }
    private static int GetUnitPart(string operand)
    {
        if (operand.EndsWith("IX")) return 9;
        if (operand.EndsWith("VIII")) return 8;
        if (operand.EndsWith("VII")) return 7;
        if (operand.EndsWith("VI")) return 6;
        if (operand.EndsWith("IV")) return 4;
        if (operand.EndsWith("V")) return 5;
        if (operand.EndsWith("III")) return 3;
        if (operand.EndsWith("II")) return 2;
        if (operand.EndsWith("I")) return 1;

        return 0;
    }

    private static string ConvertUnitToRomanNumeral(int operand)
    {
        return operand switch
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
            _ => string.Empty,
        };
    }

    private static string AddTens(
        string operand1,
        string operand2,
        int carrieFromUnit,
        out int carrie)
    {
        var tens1 = GetTensPart(operand1);
        var tens2 = GetTensPart(operand2);

        var sum = tens1 + tens2 + carrieFromUnit;
        carrie = (sum > 100)
            ? 100
            : 0;

        return ConvertTensToRomanNumeral(sum % 100);
    }

    private static int GetTensPart(string operand)
    {
        var unitPart = ConvertUnitToRomanNumeral(GetUnitPart(operand));
        var newOperand = string.IsNullOrEmpty(unitPart)
            ? operand
            : operand.Replace(unitPart, string.Empty);

        if (newOperand.EndsWith("XC")) return 90;
        if (newOperand.EndsWith("XL")) return 40;
        if (newOperand.EndsWith("L")) return 50;
        if (newOperand.EndsWith("LXX")) return 70;
        if (newOperand.EndsWith("LXXX")) return 80;
        if (newOperand.EndsWith("XXX")) return 30;
        if (newOperand.EndsWith("XX")) return 20;
        if (newOperand.EndsWith("X")) return 10;

        return 0;
    }

    private static string ConvertTensToRomanNumeral(int operand)
    {
        return operand switch
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
            _ => string.Empty,
        };
    }



}
