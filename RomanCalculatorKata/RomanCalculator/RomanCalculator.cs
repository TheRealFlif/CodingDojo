namespace RomanCalculator;

public class RomanCalculator
{
    public string Add(string operand1, string operand2)
    {
        var returnValue = AddUnit(operand1, operand2, out var carrie);
        return returnValue;
    }

    private static string AddUnit(
        string operand1, 
        string operand2, 
        out string carrie) 
    {
        var unit1 = GetUnitPart(operand1);
        var unit2 = GetUnitPart(operand2);
        var sum = unit1 + unit2;
        
        carrie = (sum > 9)
            ? "X"
            : string.Empty;

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

}
