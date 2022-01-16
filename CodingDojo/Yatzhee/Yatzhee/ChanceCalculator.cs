namespace Yatzhee
{
    using System.Collections;
    using System.Collections.Generic;

    public class ChanceCalculator
    {
        public int Calculate(Roll roll)
        {
            return 
                roll.NumberOf(Die.One())*1 + 
                roll.NumberOf(Die.Two())*2 +
                roll.NumberOf(Die.Three())*3 + 
                roll.NumberOf(Die.Four())*4+
                roll.NumberOf(Die.Five())*5+
                roll.NumberOf(Die.Six())*6;
        }
    }
}