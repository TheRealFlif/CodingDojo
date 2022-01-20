using System;
using System.Collections.Generic;

namespace Yatzhee
{
    public class Roll
    {
        public Roll()
        {
            Dices = new List<Die>()
            {
                new Die(2),
                new Die(2),
                new Die(2),
                new Die(2),
                new Die(2)
            };
        }

        public List<Die> Dices { get; set; }
    }
}
