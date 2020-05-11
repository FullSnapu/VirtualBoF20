namespace VirtualBoF20
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveNames = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.info_T2name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.info_T1name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMinusTrick = new System.Windows.Forms.Button();
            this.buttonAddTrick = new System.Windows.Forms.Button();
            this.TrickBankA = new System.Windows.Forms.ListBox();
            this.TrickBank_NameA = new System.Windows.Forms.Label();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "Trick Bank";
            this.tabControl.CausesValidation = false;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1333, 635);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SaveNames);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.info_T2name);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.info_T1name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1325, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter players name:";
            // 
            // SaveNames
            // 
            this.SaveNames.Location = new System.Drawing.Point(164, 138);
            this.SaveNames.Name = "SaveNames";
            this.SaveNames.Size = new System.Drawing.Size(42, 19);
            this.SaveNames.TabIndex = 4;
            this.SaveNames.Text = "Save";
            this.SaveNames.UseVisualStyleBackColor = true;
            this.SaveNames.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tricker B";
            // 
            // info_T2name
            // 
            this.info_T2name.Location = new System.Drawing.Point(18, 137);
            this.info_T2name.Name = "info_T2name";
            this.info_T2name.Size = new System.Drawing.Size(140, 20);
            this.info_T2name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tricker A";
            // 
            // info_T1name
            // 
            this.info_T1name.Location = new System.Drawing.Point(18, 80);
            this.info_T1name.Name = "info_T1name";
            this.info_T1name.Size = new System.Drawing.Size(140, 20);
            this.info_T1name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonMinusTrick);
            this.tabPage2.Controls.Add(this.buttonAddTrick);
            this.tabPage2.Controls.Add(this.TrickBankA);
            this.tabPage2.Controls.Add(this.TrickBank_NameA);
            this.tabPage2.Controls.Add(this.comboBoxA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1325, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trick Bank";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonMinusTrick
            // 
            this.buttonMinusTrick.Location = new System.Drawing.Point(269, 68);
            this.buttonMinusTrick.Name = "buttonMinusTrick";
            this.buttonMinusTrick.Size = new System.Drawing.Size(23, 24);
            this.buttonMinusTrick.TabIndex = 8;
            this.buttonMinusTrick.Text = "-";
            this.buttonMinusTrick.UseVisualStyleBackColor = true;
            this.buttonMinusTrick.Click += new System.EventHandler(this.buttonMinusTrick_Click);
            // 
            // buttonAddTrick
            // 
            this.buttonAddTrick.AutoSize = true;
            this.buttonAddTrick.Location = new System.Drawing.Point(269, 39);
            this.buttonAddTrick.Name = "buttonAddTrick";
            this.buttonAddTrick.Size = new System.Drawing.Size(23, 23);
            this.buttonAddTrick.TabIndex = 7;
            this.buttonAddTrick.Text = "+";
            this.buttonAddTrick.UseVisualStyleBackColor = true;
            this.buttonAddTrick.Click += new System.EventHandler(this.buttonAddTrick_Click);
            // 
            // TrickBankA
            // 
            this.TrickBankA.FormattingEnabled = true;
            this.TrickBankA.Location = new System.Drawing.Point(28, 66);
            this.TrickBankA.Name = "TrickBankA";
            this.TrickBankA.Size = new System.Drawing.Size(235, 160);
            this.TrickBankA.TabIndex = 6;
            // 
            // TrickBank_NameA
            // 
            this.TrickBank_NameA.AutoSize = true;
            this.TrickBank_NameA.Location = new System.Drawing.Point(25, 23);
            this.TrickBank_NameA.Name = "TrickBank_NameA";
            this.TrickBank_NameA.Size = new System.Drawing.Size(46, 13);
            this.TrickBank_NameA.TabIndex = 5;
            this.TrickBank_NameA.Text = "Tricker1";
            // 
            // comboBoxA
            // 
            this.comboBoxA.AllowDrop = true;
            this.comboBoxA.AutoCompleteCustomSource.AddRange(new string[] {
            "Full",
            "Cork",
            "Btwist",
            "Atwist",
            "Gainer",
            "Aerial",
            "Butterfly",
            "Cartwheel",
            "Scoot",
            "Hook",
            "Round",
            "Valdez",
            "BHS",
            "FlashKick",
            "Back Flip",
            "Gainer-Switch",
            "Side Flip",
            "Front Flip",
            "Tornado",
            "Audoban",
            "Palm Kick",
            "E-Kick",
            "Machine",
            "Coin Drop",
            "Front Sweep",
            "Back Sweep",
            "Reversao",
            "Cheat 540",
            "Cheat 720",
            "Cheat 900",
            "Swing7",
            "Swing9",
            "Sideswipe",
            "Raiz",
            "TD Raiz",
            "Shant",
            "540",
            "720 Twist",
            "Sailormoon",
            "Envergado",
            "Parafuso",
            "Jackknife",
            "Webster",
            "Sidewinder",
            "Shuriken Cutter",
            "Boxcutter",
            "Hyperhook",
            "Full Dleg",
            "Cork Dleg",
            "Btwist Dleg",
            "Atwist Dleg",
            "Full DlegTwist",
            "Cork DlegTwist",
            "Btwist DlegTwist",
            "Atwist DlegTwist",
            "Full Snapu",
            "Cork Snapu",
            "Btwist Snapu",
            "Atwist Snapu",
            "Full Swipe",
            "Cork Swipe",
            "Btwist Swipe",
            "Atwist Swipe"});
            this.comboBoxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Location = new System.Drawing.Point(28, 39);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(235, 21);
            this.comboBoxA.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1325, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Battle!";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 636);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "TDX : BoF :: Virtual Fury";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox info_T2name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox info_T1name;
        private System.Windows.Forms.Button buttonAddTrick;
        private System.Windows.Forms.ListBox TrickBankA;
        private System.Windows.Forms.Label TrickBank_NameA;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonMinusTrick;
    }
}

