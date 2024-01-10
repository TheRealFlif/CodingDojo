namespace FizzBuzz
{
    public class Fizzer
    {
        private int _valueToScramble = 3;

        public string Scramble(int value)
        {
            var scramble = 
                value % 3 == 0 || 
                value.ToString().Contains(_valueToScramble.ToString());

            return scramble
                ? "Fizz"
                : value.ToString();
        }
    }
}
