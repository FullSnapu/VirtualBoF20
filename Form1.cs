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


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTrick_Click(object sender, EventArgs e)
        {
            string listTrick = comboBoxA.Text;

            if (listTrick != "")
            {
                TrickBankA.Items.Add(listTrick);
                comboBoxA.Text = "";
            }
        }

        private void buttonMinusTrick_Click(object sender, EventArgs e)
        {
            if (TrickBankA.Items.Count > 0)
            {
                if (TrickBankA.SelectedValue != null)
                {
                    var selTrix = TrickBankA.SelectedItem;

                    TrickBankA.Items.Remove(selTrix);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameA = info_T1name.Text;

            if (NameA != null)
            {
                TrickBank_NameA.Text = NameA;
            }
        }
    }
}