using System;
using System.Collections.Generic;
using System.Linq;

namespace Yatzhee
{
    public class TwoPairCalculator
    {
        public int Calculate(Roll roll)
        {
            int score = 0;

            for (int i = 6; i > 0; i--)
            {
                var resultat = roll.Dices.Count(d => d.Number == i);
                if (resultat >= 2)
                {
                    if(score > 0)
                        return score + i * 2;
                    score += i * 2;
                }
            }

            return 0;
        }
    }
}
