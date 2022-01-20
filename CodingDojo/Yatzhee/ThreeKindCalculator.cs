using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yatzhee
{
    public class ThreeKindCalculator
    {
        public int Calculate(Roll roll)
        {
            int score = 0;

            for (int i = 6; i > 0; i--)
            {
                var resultat = roll.Dices.Count(d => d.Number == i);
                if (resultat >= 3)
                    return i * 3;
            }

            return 0;
        }
    }
}
