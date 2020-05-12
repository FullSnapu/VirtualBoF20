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
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveNames = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.playersNameB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playersNameA = new System.Windows.Forms.TextBox();
            this.tabTrickBank = new System.Windows.Forms.TabPage();
            this.btnMinusTrickX = new System.Windows.Forms.Button();
            this.btnAddTrickX = new System.Windows.Forms.Button();
            this.trickBankX = new System.Windows.Forms.ListBox();
            this.tb_NameX = new System.Windows.Forms.Label();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.btnMinusTrickB = new System.Windows.Forms.Button();
            this.btnAddTrickB = new System.Windows.Forms.Button();
            this.trickBankB = new System.Windows.Forms.ListBox();
            this.tb_NameB = new System.Windows.Forms.Label();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.btnMinusTrickA = new System.Windows.Forms.Button();
            this.btnAddTrickA = new System.Windows.Forms.Button();
            this.trickBankA = new System.Windows.Forms.ListBox();
            this.tb_NameA = new System.Windows.Forms.Label();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.tabBattle = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBeginBattle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabTrickBank.SuspendLayout();
            this.tabBattle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "Trick Bank";
            this.tabControl.CausesValidation = false;
            this.tabControl.Controls.Add(this.tabPlayers);
            this.tabControl.Controls.Add(this.tabTrickBank);
            this.tabControl.Controls.Add(this.tabBattle);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1333, 635);
            this.tabControl.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.label4);
            this.tabPlayers.Controls.Add(this.btnSaveNames);
            this.tabPlayers.Controls.Add(this.label3);
            this.tabPlayers.Controls.Add(this.playersNameB);
            this.tabPlayers.Controls.Add(this.label2);
            this.tabPlayers.Controls.Add(this.playersNameA);
            this.tabPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(1325, 609);
            this.tabPlayers.TabIndex = 0;
            this.tabPlayers.Text = "Players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter players\' names:";
            // 
            // btnSaveNames
            // 
            this.btnSaveNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNames.Location = new System.Drawing.Point(284, 330);
            this.btnSaveNames.Name = "btnSaveNames";
            this.btnSaveNames.Size = new System.Drawing.Size(74, 62);
            this.btnSaveNames.TabIndex = 4;
            this.btnSaveNames.Text = "Save";
            this.btnSaveNames.UseVisualStyleBackColor = true;
            this.btnSaveNames.Click += new System.EventHandler(this.btnSaveNames_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tricker B";
            // 
            // playersNameB
            // 
            this.playersNameB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersNameB.Location = new System.Drawing.Point(25, 330);
            this.playersNameB.Name = "playersNameB";
            this.playersNameB.Size = new System.Drawing.Size(253, 62);
            this.playersNameB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tricker A";
            // 
            // playersNameA
            // 
            this.playersNameA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersNameA.Location = new System.Drawing.Point(25, 176);
            this.playersNameA.Name = "playersNameA";
            this.playersNameA.Size = new System.Drawing.Size(253, 62);
            this.playersNameA.TabIndex = 0;
            // 
            // tabTrickBank
            // 
            this.tabTrickBank.Controls.Add(this.btnMinusTrickX);
            this.tabTrickBank.Controls.Add(this.btnAddTrickX);
            this.tabTrickBank.Controls.Add(this.trickBankX);
            this.tabTrickBank.Controls.Add(this.tb_NameX);
            this.tabTrickBank.Controls.Add(this.comboBoxX);
            this.tabTrickBank.Controls.Add(this.btnMinusTrickB);
            this.tabTrickBank.Controls.Add(this.btnAddTrickB);
            this.tabTrickBank.Controls.Add(this.trickBankB);
            this.tabTrickBank.Controls.Add(this.tb_NameB);
            this.tabTrickBank.Controls.Add(this.comboBoxB);
            this.tabTrickBank.Controls.Add(this.btnMinusTrickA);
            this.tabTrickBank.Controls.Add(this.btnAddTrickA);
            this.tabTrickBank.Controls.Add(this.trickBankA);
            this.tabTrickBank.Controls.Add(this.tb_NameA);
            this.tabTrickBank.Controls.Add(this.comboBoxA);
            this.tabTrickBank.Location = new System.Drawing.Point(4, 22);
            this.tabTrickBank.Name = "tabTrickBank";
            this.tabTrickBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrickBank.Size = new System.Drawing.Size(1325, 609);
            this.tabTrickBank.TabIndex = 1;
            this.tabTrickBank.Text = "Trick Bank";
            this.tabTrickBank.UseVisualStyleBackColor = true;
            // 
            // btnMinusTrickX
            // 
            this.btnMinusTrickX.AutoSize = true;
            this.btnMinusTrickX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinusTrickX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTrickX.Location = new System.Drawing.Point(562, 200);
            this.btnMinusTrickX.Name = "btnMinusTrickX";
            this.btnMinusTrickX.Size = new System.Drawing.Size(122, 33);
            this.btnMinusTrickX.TabIndex = 18;
            this.btnMinusTrickX.TabStop = false;
            this.btnMinusTrickX.Tag = "X";
            this.btnMinusTrickX.Text = "Remove Trick";
            this.btnMinusTrickX.UseVisualStyleBackColor = true;
            // 
            // btnAddTrickX
            // 
            this.btnAddTrickX.AutoSize = true;
            this.btnAddTrickX.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrickX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrickX.Location = new System.Drawing.Point(706, 200);
            this.btnAddTrickX.Name = "btnAddTrickX";
            this.btnAddTrickX.Size = new System.Drawing.Size(91, 33);
            this.btnAddTrickX.TabIndex = 15;
            this.btnAddTrickX.Tag = "X";
            this.btnAddTrickX.Text = "Add Trick";
            this.btnAddTrickX.UseVisualStyleBackColor = true;
            this.btnAddTrickX.Click += new System.EventHandler(this.btnAddTrickX_Click);
            // 
            // trickBankX
            // 
            this.trickBankX.AllowDrop = true;
            this.trickBankX.DisplayMember = "Trick Bank B";
            this.trickBankX.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trickBankX.FormattingEnabled = true;
            this.trickBankX.ItemHeight = 59;
            this.trickBankX.Location = new System.Drawing.Point(562, 239);
            this.trickBankX.Name = "trickBankX";
            this.trickBankX.Size = new System.Drawing.Size(235, 299);
            this.trickBankX.TabIndex = 17;
            this.trickBankX.Tag = "X";
            // 
            // tb_NameX
            // 
            this.tb_NameX.AutoSize = true;
            this.tb_NameX.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameX.Location = new System.Drawing.Point(552, 65);
            this.tb_NameX.Name = "tb_NameX";
            this.tb_NameX.Size = new System.Drawing.Size(104, 59);
            this.tb_NameX.TabIndex = 16;
            this.tb_NameX.Tag = "X";
            this.tb_NameX.Text = "TDX";
            // 
            // comboBoxX
            // 
            this.comboBoxX.AllowDrop = true;
            this.comboBoxX.AutoCompleteCustomSource.AddRange(new string[] {
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissorswipe"});
            this.comboBoxX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxX.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissor"});
            this.comboBoxX.Location = new System.Drawing.Point(562, 127);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(235, 67);
            this.comboBoxX.TabIndex = 14;
            this.comboBoxX.Tag = "X";
            // 
            // btnMinusTrickB
            // 
            this.btnMinusTrickB.AutoSize = true;
            this.btnMinusTrickB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinusTrickB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTrickB.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMinusTrickB.Location = new System.Drawing.Point(295, 200);
            this.btnMinusTrickB.Name = "btnMinusTrickB";
            this.btnMinusTrickB.Size = new System.Drawing.Size(122, 33);
            this.btnMinusTrickB.TabIndex = 13;
            this.btnMinusTrickB.TabStop = false;
            this.btnMinusTrickB.Text = "Remove Trick";
            this.btnMinusTrickB.UseVisualStyleBackColor = true;
            this.btnMinusTrickB.Click += new System.EventHandler(this.btnMinusTrickB_Click);
            // 
            // btnAddTrickB
            // 
            this.btnAddTrickB.AutoSize = true;
            this.btnAddTrickB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrickB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrickB.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAddTrickB.Location = new System.Drawing.Point(439, 200);
            this.btnAddTrickB.Name = "btnAddTrickB";
            this.btnAddTrickB.Size = new System.Drawing.Size(91, 33);
            this.btnAddTrickB.TabIndex = 8;
            this.btnAddTrickB.Text = "Add Trick";
            this.btnAddTrickB.UseVisualStyleBackColor = true;
            this.btnAddTrickB.Click += new System.EventHandler(this.btnAddTrickB_Click);
            // 
            // trickBankB
            // 
            this.trickBankB.AllowDrop = true;
            this.trickBankB.DisplayMember = "Trick Bank B";
            this.trickBankB.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trickBankB.ForeColor = System.Drawing.Color.DarkRed;
            this.trickBankB.FormattingEnabled = true;
            this.trickBankB.ItemHeight = 59;
            this.trickBankB.Location = new System.Drawing.Point(295, 239);
            this.trickBankB.Name = "trickBankB";
            this.trickBankB.Size = new System.Drawing.Size(235, 299);
            this.trickBankB.TabIndex = 11;
            this.trickBankB.Tag = "B";
            // 
            // tb_NameB
            // 
            this.tb_NameB.AutoSize = true;
            this.tb_NameB.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameB.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_NameB.Location = new System.Drawing.Point(285, 65);
            this.tb_NameB.Name = "tb_NameB";
            this.tb_NameB.Size = new System.Drawing.Size(197, 59);
            this.tb_NameB.TabIndex = 10;
            this.tb_NameB.Text = "Tricker B";
            // 
            // comboBoxB
            // 
            this.comboBoxB.AllowDrop = true;
            this.comboBoxB.AutoCompleteCustomSource.AddRange(new string[] {
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissorswipe"});
            this.comboBoxB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxB.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxB.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Items.AddRange(new object[] {
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissor"});
            this.comboBoxB.Location = new System.Drawing.Point(295, 127);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(235, 67);
            this.comboBoxB.TabIndex = 7;
            this.comboBoxB.Tag = "B";
            // 
            // btnMinusTrickA
            // 
            this.btnMinusTrickA.AutoSize = true;
            this.btnMinusTrickA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinusTrickA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusTrickA.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMinusTrickA.Location = new System.Drawing.Point(21, 200);
            this.btnMinusTrickA.Name = "btnMinusTrickA";
            this.btnMinusTrickA.Size = new System.Drawing.Size(122, 33);
            this.btnMinusTrickA.TabIndex = 8;
            this.btnMinusTrickA.TabStop = false;
            this.btnMinusTrickA.Tag = "A";
            this.btnMinusTrickA.Text = "Remove Trick";
            this.btnMinusTrickA.UseVisualStyleBackColor = true;
            this.btnMinusTrickA.Click += new System.EventHandler(this.btnMinusTrickA_Click);
            // 
            // btnAddTrickA
            // 
            this.btnAddTrickA.AutoSize = true;
            this.btnAddTrickA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTrickA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrickA.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddTrickA.Location = new System.Drawing.Point(165, 200);
            this.btnAddTrickA.Name = "btnAddTrickA";
            this.btnAddTrickA.Size = new System.Drawing.Size(91, 33);
            this.btnAddTrickA.TabIndex = 5;
            this.btnAddTrickA.Text = "Add Trick";
            this.btnAddTrickA.UseVisualStyleBackColor = true;
            this.btnAddTrickA.Click += new System.EventHandler(this.btnAddTrickA_Click);
            // 
            // trickBankA
            // 
            this.trickBankA.AllowDrop = true;
            this.trickBankA.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trickBankA.ForeColor = System.Drawing.Color.DarkBlue;
            this.trickBankA.FormatString = "\'•\'{0}";
            this.trickBankA.FormattingEnabled = true;
            this.trickBankA.ItemHeight = 59;
            this.trickBankA.Location = new System.Drawing.Point(21, 239);
            this.trickBankA.Name = "trickBankA";
            this.trickBankA.Size = new System.Drawing.Size(235, 299);
            this.trickBankA.TabIndex = 6;
            this.trickBankA.Tag = "A";
            // 
            // tb_NameA
            // 
            this.tb_NameA.AutoSize = true;
            this.tb_NameA.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameA.ForeColor = System.Drawing.Color.DarkBlue;
            this.tb_NameA.Location = new System.Drawing.Point(11, 65);
            this.tb_NameA.Name = "tb_NameA";
            this.tb_NameA.Size = new System.Drawing.Size(199, 59);
            this.tb_NameA.TabIndex = 5;
            this.tb_NameA.Text = "Tricker A";
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissorswipe"});
            this.comboBoxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxA.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxA.ForeColor = System.Drawing.Color.DarkBlue;
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Items.AddRange(new object[] {
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
            "Atwist Swipe",
            "Pop3",
            "Pop7",
            "Pop9",
            "DoubleLeg",
            "Dleg",
            "MasterSwipe",
            "GMS",
            "GMScoot",
            "GMSnapu",
            "GMS-Helicoptero",
            "PopSwipe",
            "Arabian",
            "Double Full",
            "Triple Full",
            "Quad Full",
            "Tak",
            "Tak9",
            "Scissor"});
            this.comboBoxA.Location = new System.Drawing.Point(21, 127);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(235, 67);
            this.comboBoxA.TabIndex = 4;
            this.comboBoxA.Tag = "A";
            // 
            // tabBattle
            // 
            this.tabBattle.Controls.Add(this.label6);
            this.tabBattle.Controls.Add(this.label5);
            this.tabBattle.Controls.Add(this.btnBeginBattle);
            this.tabBattle.Controls.Add(this.label1);
            this.tabBattle.Location = new System.Drawing.Point(4, 22);
            this.tabBattle.Name = "tabBattle";
            this.tabBattle.Padding = new System.Windows.Forms.Padding(3);
            this.tabBattle.Size = new System.Drawing.Size(1325, 609);
            this.tabBattle.TabIndex = 2;
            this.tabBattle.Text = "Battle!";
            this.tabBattle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Round 1 Combo";
            // 
            // btnBeginBattle
            // 
            this.btnBeginBattle.Location = new System.Drawing.Point(51, 19);
            this.btnBeginBattle.Name = "btnBeginBattle";
            this.btnBeginBattle.Size = new System.Drawing.Size(79, 28);
            this.btnBeginBattle.TabIndex = 1;
            this.btnBeginBattle.Text = "Begin Battle!";
            this.btnBeginBattle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Round 3 Combo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Round 2 Combo";
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
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabTrickBank.ResumeLayout(false);
            this.tabTrickBank.PerformLayout();
            this.tabBattle.ResumeLayout(false);
            this.tabBattle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabTrickBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playersNameB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playersNameA;
        private System.Windows.Forms.Button btnAddTrickA;
        private System.Windows.Forms.ListBox trickBankA;
        private System.Windows.Forms.Label tb_NameA;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.TabPage tabBattle;
        private System.Windows.Forms.Button btnMinusTrickA;
        private System.Windows.Forms.Button btnMinusTrickB;
        private System.Windows.Forms.Button btnAddTrickB;
        private System.Windows.Forms.ListBox trickBankB;
        private System.Windows.Forms.Label tb_NameB;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.Button btnMinusTrickX;
        private System.Windows.Forms.Button btnAddTrickX;
        private System.Windows.Forms.ListBox trickBankX;
        private System.Windows.Forms.Label tb_NameX;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBeginBattle;
        private System.Windows.Forms.Label label1;
    }
}

