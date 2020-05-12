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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveNames_Click(object sender, EventArgs e)
        {
            string trkrA = playersNameA.Text;
            string trkrB = playersNameB.Text;

            if (trkrA != null)
            {
                tb_NameA.Text = trkrA.ToUpper();
            }

            if (trkrB != null)
            {
                tb_NameB.Text = trkrB.ToUpper();
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
        private void btnMinusTrickA_Click(object sender, EventArgs e)
        {
            minusTrickBank(trickBankA);
        }

        private void btnMinusTrickB_Click(object sender, EventArgs e)
        {
            minusTrickBank(trickBankB);
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
                else (player == "X")
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

        private void btnAddTrickX_Click(object sender, EventArgs e)
        {

        }
    }
}