namespace BankOCR;

public class AccountCharacter
{
    public AccountCharacter(
        string[] rows)
    {
        FirstRow = rows[0];
        SecondRow = rows[1];
        ThirdRow = rows[2];
    }

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

    public static Dictionary<int, string[]> StringForNumber
    {
        get
        {
            return new Dictionary<int, string[]> {
                {0,  new[] { " _ ", "| |", "|_|" } },
                {1,  new[] { "   ", "  |", "  |" } },
                {2,  new[] { " _ ", " _|", "|_ " } },
                {3,  new[] { " _ ", " _|", " _|" } },
                {4,  new[] { "   ", "|_|", "  |" } },
                {5,  new[] { " _ ", "|_ ", " _|" } },
                {6,  new[] { " _ ", "|_ ", "|_|" } },
                {7,  new[] { " _ ", "  |", "  |" } },
                {8,  new[] { " _ ", "|_|", "|_|" } },
                {9,  new[] { " _ ", "|_|", " _|" } }
            };
        }
    }

    public static AccountCharacter Blank() => new AccountCharacter("   ", "   ", "   ");
    public static AccountCharacter Zero() => new AccountCharacter(StringForNumber[0]);
    public static AccountCharacter One() => new AccountCharacter(StringForNumber[1]);
    public static AccountCharacter Two() => new AccountCharacter(StringForNumber[2]);
    public static AccountCharacter Three() => new AccountCharacter(StringForNumber[3]);
    public static AccountCharacter Four() => new AccountCharacter(StringForNumber[4]);
    public static AccountCharacter Five() => new AccountCharacter(StringForNumber[5]);
    public static AccountCharacter Six() => new AccountCharacter(StringForNumber[6]);
    public static AccountCharacter Seven() => new AccountCharacter(StringForNumber[7]);
    public static AccountCharacter Eight() => new AccountCharacter(StringForNumber[8]);
    public static AccountCharacter Nine() => new AccountCharacter(StringForNumber[9]);

    public string FirstRow { get; init; }
    public string SecondRow { get; init; }
    public string ThirdRow { get; init; }
    public int Value
    {
        get
        {
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

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstRow, SecondRow, ThirdRow);
    }

    public override string ToString()
    {
        return $"{FirstRow}\n{SecondRow}\n{ThirdRow}";
    }
}
