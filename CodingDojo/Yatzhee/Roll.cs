using System;
using System.Collections.Generic;
using System.Linq;

namespace Yatzhee
{
    public class Roll
    {
        public Roll(int die1, int die2, int die3, int die4, int die5)
        {
            Dices = new List<Die>()
            {
                new Die(die1),
                new Die(die2),
                new Die(die3),
                new Die(die4),
                new Die(die5)
            };
        }

        public List<Die> Dices { get; set; }

        public int PairScore()
        {
            for (int i = 6; i > 0; i--)
            {
                var resultat = Dices.Count(d => d.Number == i);
                if (resultat >= 2)
                    return i * 2;
            }

            return 0;
        }
    }
}
