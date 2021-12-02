using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulation
{
   public class Gambling
    {
        public int stake = 100;
        public int bet = 1;
       public const int WIN = 1;
       public const int LOOSE = 0;
        public void check()
        {
            Random rand = new Random();
            int check = rand.Next(0, 2);
            if (check == WIN)
            {
                stake = stake + 1;//wins
            }
            else if (check == LOOSE)
            {
                stake = stake - 1;//looses
            }

        }
    }
}
