namespace FizzBuzz
{
    public class FizzBuzzer : IScrambler
    {
        private IScrambler fizzer = new Fizzer();
        private IScrambler buzzer = new Buzzer();

        public string Scramble(int value)
        {
            var fizz = fizzer.Scramble(value);
            var buzz = buzzer.Scramble(value);

            fizz = fizz == value.ToString()
                ? string.Empty
                : fizz;

            buzz = buzz == value.ToString()
                ? string.Empty
                : buzz;

            var returnValue = $"{fizz}{buzz}";
            returnValue = returnValue == string.Empty
                ? value.ToString()
                : returnValue;

            return returnValue;
        }
    }
}
