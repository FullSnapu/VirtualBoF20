using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBoF20
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void btnSaveNames_Click(object sender, EventArgs e)
        {
            string trkrA = playersNameA.Text;
            string trkrB = playersNameB.Text;

            if (trkrA != null && trkrB != null)
            {
                tb_NameA.Text = trkrA.ToUpper();
                tb_NameB.Text = trkrB.ToUpper();

                radio_TA1.Text = trkrA;
                radio_TA2.Text = trkrA;
                radio_TA3.Text = trkrA;

                radio_TB1.Text = trkrB;
                radio_TB2.Text = trkrB;
                radio_TB3.Text = trkrB;
            }

            tabControl.SelectedTab = tabTrickBank;

        }

        private void btnAddTrickA_Click(object sender, EventArgs e)
        {
            addTrickBank(comboBoxA);
        }

        private void btnAddTrickB_Click(object sender, EventArgs e)
        {
            addTrickBank(comboBoxB);
        }
        private void btnAddTrickX_Click(object sender, EventArgs e)
        {
            addTrickBank(comboBoxX);
        }
        private void btnMinusTrickA_Click(object sender, EventArgs e)
        {
            minusTrickBank(trickBankA);
        }

        private void btnMinusTrickB_Click(object sender, EventArgs e)
        {
            minusTrickBank(trickBankB);
        }

        private void btnMinusTrickX_Click(object sender, EventArgs e)
        {
            minusTrickBank(trickBankX);
        }

        private void addTrickBank(ComboBox newtrickbox)
        {
            string newTrick = newtrickbox.Text;
            string player = newtrickbox.Tag.ToString();
            ListBox trickBank;

            //if valid entry
            if (newTrick != "")
            {
                //determine which trickbank to add to
                if (player == "A")
                {
                    trickBank = trickBankA;
                }
                else if (player == "B")
                {
                    trickBank = trickBankB;
                }
                else //if(player == "X")
                {
                    trickBank = trickBankX;
                }

                if (trickBank.Items.Count < 5)
                {
                    //add new trick to trickbank
                    trickBank.Items.Add(newTrick);
                }

                else
                {
                    //alert user that trick bank max reached
                    MessageBox.Show("TrickBank holds a maximum of 5 tricks!","TrickBank:" + player);
                }

                //clear new entry
                newtrickbox.Text = "";
                newtrickbox.Focus();
            }
        }

        private void minusTrickBank(ListBox trickbank)
        {
            if (trickbank.SelectedItem != null)
            {
                var selectTrick = trickbank.SelectedItem;

                trickbank.Items.Remove(selectTrick);

            }
        }


        private void btnBeginRound1_Click(object sender, EventArgs e)
        {
            BeginBattleRound(1);
        }
        private void btnBeginRound2_Click(object sender, EventArgs e)
        {
            BeginBattleRound(2);
        }
        private void btnBeginRound3_Click(object sender, EventArgs e)
        {
            BeginBattleRound(3);
        }



        //creates a non repeating instance of random
        static Random random = new Random();

        private bool ValidateTrickBanks()
        {
            //checks that trickbanks have 5 tricks each
            int tbAcount = trickBankA.Items.Count;
            int tbBcount = trickBankB.Items.Count;
            int tbXcount = trickBankX.Items.Count;

            bool tbA = tbAcount ==5;
            bool tbB = tbBcount == 5;
            bool tbX = tbXcount == 5;

            string countErr_str = Environment.NewLine;
            bool isErr = false;

            //if !5 count, add trickbank name to error string
            if (!tbA)
            {
                countErr_str += "- A" + Environment.NewLine;
                isErr = true;
            }
            if (!tbB)
            {
                countErr_str += "- B" + Environment.NewLine;
                isErr = true;
            }
            if (!tbX)
            {
                countErr_str += "- TDX" + Environment.NewLine;
                isErr = true;
            }

            if (isErr)
            {
                string msg = "Not all TrickBanks are full:" + countErr_str + "Please fill banks before beginning the battle!";
                string msgHdr = "Let's Battle!";
                MessageBox.Show(msg, msgHdr);
            }

            return !isErr;

        }



        private void BeginBattleRound(int roundNum)
        {
            if (ValidateTrickBanks())
            {
                RoundCombo round = new RoundCombo();
                ListBox thisRoundTricks = null;

                round.RoundNum = roundNum;
                round.TrickBankA = trickBankA.Items.OfType<string>().ToArray();
                round.TrickBankB = trickBankB.Items.OfType<string>().ToArray();
                round.TrickBankX = trickBankX.Items.OfType<string>().ToArray();
                string[] TrickArr = round.Tricks;

                //depending on roundnum assign which list box to variable
                switch (roundNum)
                {
                    case 1:
                        thisRoundTricks = Round1_listbox;
                        break;
                    case 2:
                        thisRoundTricks = Round2_listbox;
                        break;
                    case 3:
                        thisRoundTricks = Round3_listbox;
                        break;
                }
                
                //clear previous tricks in thisRound's listbox
                thisRoundTricks.Items.Clear();

                for (int i = 0; i < TrickArr.Length; i++)
                {
                    thisRoundTricks.Items.Add(TrickArr[i].ToString());
                }
            }
        }

        private void btn_flipCoin_Click(object sender, EventArgs e)
        {
            if (rbtn_Heads.Enabled)
            {
                string userguess = "Heads";
            }

            else
            {
                string userguess = "Tails";
            }


        }


    }
}