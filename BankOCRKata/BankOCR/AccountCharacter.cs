namespace BankOCR;

public class AccountCharacter
{
    public AccountCharacter(
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
    public static AccountCharacter Four() => new AccountCharacter("   ", "|_|", "  |");
    public static AccountCharacter Five() => new AccountCharacter(" _ ", "|_ ", " _|");
    public static AccountCharacter Six() => new AccountCharacter(" _ ", "|_ ", "|_|");
    public static AccountCharacter Seven() => new AccountCharacter(" _ ", "  |", "  |");
    public static AccountCharacter Eight() => new AccountCharacter(" _ ", "|_|", "|_|");
    public static AccountCharacter Nine() => new AccountCharacter(" _ ", "|_|", " _|");

    public string FirstRow { get; init; }
    public string SecondRow { get; init; }
    public string ThirdRow { get; init; }
    public int Value
    {
        get {
            var lookup = new Dictionary<AccountCharacter, int> {
                {One(), 1},
                {Two(), 2},
                {Three(), 3},
                {Four(), 4},
                {Five(), 5},
                {Six(), 6},
                {Seven(), 7},
                {Eight(), 8},
                {Nine(), 9},
            };

            return lookup.TryGetValue(this, out var returnValue)
                ? returnValue
                : 0;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is AccountCharacter character &&
            character.FirstRow == FirstRow &&
            character.SecondRow == SecondRow &&
            character.ThirdRow == ThirdRow;
    }

    public override string ToString()
    {
        return $"{Value} = {FirstRow}\n{SecondRow}\n{ThirdRow}";
    }
}
