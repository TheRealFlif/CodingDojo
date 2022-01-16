namespace Yatzhee
{
    using System.Collections.Generic;

    public class Roll
    {
        private readonly int[] _diceValues = new int[6];
        
        public Roll AddDie(Die die)
        {
            _diceValues[die.Value - 1] += 1;
            return this;
        }

        public Roll AddDices(IEnumerable<Die> dice)
        {
            foreach (var die in dice)
            {
                AddDie(die);
            }

            return this;
        }
        
        public int NumberOf(Die die)
        {
            return _diceValues[die.Value - 1];
        }
    }
}