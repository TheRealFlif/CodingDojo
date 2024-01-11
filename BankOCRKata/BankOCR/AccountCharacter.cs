namespace BankOCR;

public class AccountCharacter
{
    private AccountCharacter(
        string firstRow,
        string secondRow,
        string thirdRow)
    {
        FirstRow = firstRow;
        SecondRow = secondRow;
        ThirdRow = thirdRow;
    }

    public static AccountCharacter Create(int i)
    {
        return i switch
        {
            0 => Zero(),
            1 => One()
        };
    }

    public static AccountCharacter Blank()
    {
        return new AccountCharacter("   ", "   ", "   ");
    }

    public static AccountCharacter Zero()
    {
        return new AccountCharacter(" _ ", "| |", "|_|");
    }

    public static AccountCharacter One()
    {
        return new AccountCharacter("   ", "  |", "  |");
    }

    public string FirstRow { get; init; }
    public string SecondRow { get; init; }
    public string ThirdRow { get; init; }

    public override string ToString()
    {
        return $"{FirstRow}\n{SecondRow}\n{ThirdRow}";
    }
}
