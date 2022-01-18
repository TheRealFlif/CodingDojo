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
                new Die(),
                new Die(),
                new Die(),
                new Die(),
                new Die()
            };
        }

        public List<Die> Dices { get; set; }
    }
}
