using System;

namespace dicegame
{
    public class Die
    {
        public int value = 0;
        public int points = 0;

        public Die()
        {

        }

        public void Roll()
        {   
            Random number = new Random();
            value = number.Next(1, 7);

            if (value == 5)
            {
                points = 50;
            }
            else if (value == 1)
            {
                points = 100;
            }
            else
            {
                points = 0;
            }
        }
    }
}
