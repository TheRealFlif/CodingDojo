using System.Text;

namespace BankOCR;

public class AccountLine
{
    private AccountCharacter[] _characters = new AccountCharacter[9];

    public AccountLine AddCharachter(AccountCharacter character)
    {
        for (int i = 0; i < _characters.Length; i++)
        {
            if (_characters[i] == null)
            {
                _characters[i] = character;
            }
        }

        return this;
    }

    public AccountLine AddCharachter(int value)
    {
        for (int i = 0; i < _characters.Length; i++)
        {
            if (_characters[i] == null)
            {
                _characters[i] = AccountCharacter.Create(value);
                break;
            }
        }

        return this;
    }

    public AccountLine SetCharacter(int index, AccountCharacter character)
    {
        _characters[index] = character;
        return this;
    }

    public AccountLine SetCharacter(int index, int value)
    {
        _characters[index] = AccountCharacter.Create(value);
        return this;
    }

    public static AccountLine Create(string characterLine)
    {
        var returnValue = new AccountLine();
        string[] lines = characterLine.Split("\r\n");
        for (int i = 0; i < 27; i = i + 3)
        {
            var character = new AccountCharacter(
                new string(lines[0].Skip(i).Take(3).ToArray()),
                new string(lines[1].Skip(i).Take(3).ToArray()),
                new string(lines[2].Skip(i).Take(3).ToArray()));

            returnValue.AddCharachter(character);
        }

        return returnValue;
    }

    public IEnumerable<int> ToIntegers()
    {
        return _characters.Select(c => c.Value);
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder(30);
        for (int i = 0; i < _characters.Length; i++)
        {
            stringBuilder.Append(_characters[i].FirstRow);
        }
        stringBuilder.AppendLine();
        for (int i = 0; i < _characters.Length; i++)
        {
            stringBuilder.Append(_characters[i].SecondRow);
        }
        stringBuilder.AppendLine();
        for (int i = 0; i < _characters.Length; i++)
        {
            stringBuilder.Append(_characters[i].ThirdRow);
        }
        stringBuilder.AppendLine();

        return stringBuilder.ToString();
    }
}
