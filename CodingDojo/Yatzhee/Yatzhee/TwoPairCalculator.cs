namespace Yatzhee
{
    using System.Collections;
    using System.ComponentModel.Design.Serialization;
    using System.Text.RegularExpressions;

    public class TwoPairCalculator
    {
        public int Calculate(Roll roll)
        {
            if (roll.NumberOf(Die.Six()) >= 2)
                return 12;
            
            if (roll.NumberOf(Die.Five()) >= 2)
                return 10;
            
            if (roll.NumberOf(Die.Four()) >= 2)
                return 8;
            
            if (roll.NumberOf(Die.Three()) >= 2)
                return 6;
            
            if (roll.NumberOf(Die.Two()) >= 2)
                return 4;
            
            if (roll.NumberOf(Die.One()) >= 2)
                return 2;

            return 0;
        }
    }
}
