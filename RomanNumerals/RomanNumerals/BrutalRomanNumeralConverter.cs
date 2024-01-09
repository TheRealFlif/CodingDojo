namespace RomanNumerals
{
    public class BrutalRomanNumeralConverter
    {
        public int Convert(string romanNumeral)
        {
            var converter = new Converter();

            for (int i = 0; i <= int.MaxValue; i++)
            {
                if (i % 10000 == 0)
                { System.Diagnostics.Debug.WriteLine(i); }
                if (converter.Convert(i) == romanNumeral)
                {
                    return i;
                }
            }

            return 0;
        }
    }
}