using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBoF20
{
    class CoinFlip
    {
        private string headsOrTails;
        private string userGuess;
        private bool outcome;

        public string HeadsOrTails
        {
            get
            {
                //1= head , 2 = tails
                int ht = rand.Next(1, 3);
                if (ht.Equals(1))
                {
                    headsOrTails = "Heads";
                }
                else
                {
                    headsOrTails = "Tails";
                }
                    return headsOrTails;
            }

            set
            {
                headsOrTails = value;
            }


        }

        public string UserGuess
        {
            get
            {
                return userGuess;
            }
            set
            {
                userGuess = value;
            }
        }

        public bool Outcome
        {
            get
            {
                if (UserGuess == HeadsOrTails)
                {
                    outcome = true;
                }
                return outcome;
            }

        }


        //creates random number in its own instance to prevent duplicates
        private static readonly Random rand = new Random();

    }
}
