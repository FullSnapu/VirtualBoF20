using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBoF20
{
    class RoundCombo
    {
        private int roundnum;
        private string[] trickbankA;
        private string[] trickbankB;
        private string[] trickbankX;
        private string[] tricks;

        public int RoundNum
        {
            get
            {
                return roundnum;
            }

            set
            {
                //property setting validation
                if (value < 1 || value > 3)
                {
                    throw new OverflowException();
                }
                roundnum = value;
            }
        }

        public string[] TrickBankA
        {
            get
            {
                return trickbankA;
            }
            set
            {
                trickbankA = value;
            }
        }

        public string[] TrickBankB
        {
            get
            {
                return trickbankB;
            }
            set
            {
                trickbankB = value;
            }
        }

        public string[] TrickBankX
        {
            get
            {
                return trickbankX;
            }
            set
            {
                trickbankX = value;
            }
        }

         public string[] Tricks
        {
            get
            {
                int[] tricktypecounts = GetTrickTypeCounts();
                int amtA = tricktypecounts[0];
                int amtB = tricktypecounts[1];
                int amtX = tricktypecounts[2];

                string tricksA = GetFromTrickBank(0, amtA);
                string tricksB = GetFromTrickBank(1, amtB);
                string tricksX = GetFromTrickBank(2, amtX);

                string StrTricks = tricksA + tricksB + tricksX;
                string[] ArrTricks = StrTricks.Split(';');
                tricks = ShuffleArray(ArrTricks);
                
                return tricks;
            }
        }

        public static string[] ShuffleArray(String[] Arr)
        {
            string temp;
            Arr = Arr.Where(a => !string.IsNullOrEmpty(a)).ToArray();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                int j = rand.Next(i, Arr.Length);
                temp = Arr[i];
                Arr[i] = Arr[j];
                Arr[j] = temp;
            }
            return Arr;
        }

        //creates random number in its own instance to prevent duplicates
        private static readonly Random rand = new Random();

        private int[] GetTrickTypeCounts()
        {
            //based on the round number, determines the amounts from each trickbank
            //returns as array
            int amtA = 0;
            int amtB = 0;
            int amtX = 0;

            int[] typeCounts = new int [3];

            switch (RoundNum)
            {
                case 1:
                    amtA = 3;
                    amtX = 2;
                    break;
                case 2:
                    amtB = 3;
                    amtX = 2;
                    break;
                case 3:
                    amtA = 2;
                    amtB = 2;
                    amtX = 1;
                    break;
            }

            typeCounts[0] = amtA;
            typeCounts[1] = amtB;
            typeCounts[2] = amtX;

            return typeCounts;

        }

        private string GetFromTrickBank(int trickBankNum, int count)
        {
            //takes which trickbank and the number and grab random tricks.
            string[] Trx_arr = null;
            string Trx_Str = null;
            int index;

            switch (trickBankNum)
            {
                case 0:
                    Trx_arr = TrickBankA;
                    break;
                case 1:
                    Trx_arr = TrickBankB;
                    break;
                case 2:
                    Trx_arr = TrickBankX;
                    break;
            }

            for (int r = 0; r < count; r++)
            {
                index = rand.Next(0, Trx_arr.Length);
                Trx_Str += Trx_arr[index] + ";";
            }

            return Trx_Str;
        }

        
    }
}
