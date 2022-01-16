namespace Yatzhee
{
    public class PairCalculator
    {
        public int Calculate(Roll roll)
        {
            return 
                roll.NumberOf(Die.Six()) >= 2 ? 12 
                : roll.NumberOf(Die.Five()) >= 2 ? 10 
                : roll.NumberOf(Die.Four()) >= 2 ? 8 
                : roll.NumberOf(Die.Three()) >= 2 ? 6 
                : roll.NumberOf(Die.Two()) >= 2 ? 4 
                : roll.NumberOf(Die.One()) >= 2 ? 2 
                : 0;
        }
    }
}