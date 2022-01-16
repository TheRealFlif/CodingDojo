namespace Yatzhee
{
    public class Die
    {
        private Die(int value)
        {
            Value = value;
        }
        public int Value { get;}
        public static Die One()
        {
            return new Die(1);
        }
        
        public static Die Two()
        {
            return new Die(2);
        }
        
        public static Die Three()
        {
            return new Die(3);
        }
        
        public static Die Four()
        {
            return new Die(4);
        }
        
        public static Die Five()
        {
            return new Die(5);
        }
        
        public static Die Six()
        {
            return new Die(6);
        }
    }
}