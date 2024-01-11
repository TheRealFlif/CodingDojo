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
            1 => One(),
            2 => Two(),
            3 => Three(),
            4 => Four(),
            5 => Five(),
            6 => Six(),
            7 => Seven(),
            8 => Eight(),
            9 => Nine(),
            _ => Blank()
        };
    }

    public static AccountCharacter Blank() => new AccountCharacter("   ", "   ", "   ");
    public static AccountCharacter Zero() => new AccountCharacter(" _ ", "| |", "|_|");
    public static AccountCharacter One() =>  new AccountCharacter("   ", "  |", "  |");
    public static AccountCharacter Two() => new AccountCharacter(" _ ", " _|", "|_ ");
    public static AccountCharacter Three() => new AccountCharacter(" _ ", " _|", " _|");
    public static AccountCharacter Four() => new AccountCharacter("  ", "|_|", "  |");
    public static AccountCharacter Five() => new AccountCharacter(" _ ", "|_ ", " _|");
    public static AccountCharacter Six() => new AccountCharacter(" _ ", "|_ ", "|_|");
    public static AccountCharacter Seven() => new AccountCharacter(" _ ", "  |", "  |");
    public static AccountCharacter Eight() => new AccountCharacter(" _ ", "|_|", "|_|");
    public static AccountCharacter Nine() => new AccountCharacter(" _ ", "|_|", " _|");

    public string FirstRow { get; init; }
    public string SecondRow { get; init; }
    public string ThirdRow { get; init; }

    public override string ToString()
    {
        return $"{FirstRow}\n{SecondRow}\n{ThirdRow}";
    }
}
