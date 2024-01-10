namespace FizzBuzz
{
    public class Fizzer
    {
        public string Scramble(int value)
        {
            return value % 3 == 0
                ? "Fizz"
                : value.ToString();
        }
    }
}
