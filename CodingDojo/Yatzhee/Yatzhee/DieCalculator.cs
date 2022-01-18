namespace Yatzhee
{
    public abstract class DieCalculator
    {
        private readonly Die _die;

        protected DieCalculator(Die die)
        {
            _die = die;
        }

        public int Calculate(Roll roll)
        {
            return roll.NumberOf(_die) * _die.Value;
        }
    }
}
