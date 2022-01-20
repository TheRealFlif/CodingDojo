using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzhee
{
    public class Die
    {
        public int Number;
        public Die(int number)
        {
            Number = number;
        }

        public int Read()
        {
            return Number;
        }
    }
}
