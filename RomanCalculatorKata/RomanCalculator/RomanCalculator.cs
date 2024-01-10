namespace RomanCalculator;

public class RomanCalculator
{
    public string Add(string operand1, string operand2)
    {
        return string.IsNullOrEmpty(operand1)
            ? operand2 
            : operand1;
    }
}
