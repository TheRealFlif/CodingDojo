namespace FizzBuzz
{
    public class ScramblerBase : IScrambler
    {
        private readonly int valueToScramble;
        private readonly string scrambledValue;

        public ScramblerBase(
            int valueToScramble,
            string scrambledValue)
        {
            this.valueToScramble = valueToScramble;
            this.scrambledValue = scrambledValue;
        }

        public virtual string Scramble(int value)
        {
            var scramble =
               value % valueToScramble == 0 ||
               value.ToString().Contains(valueToScramble.ToString());

            return scramble
                ? scrambledValue
                : value.ToString();
        }
    }
}
