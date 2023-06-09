namespace Randomizer_Bingo
{
    partial class Intro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.freespacechk = new System.Windows.Forms.CheckBox();
            this.finishintrobtn = new System.Windows.Forms.Button();
            this.seedtxtbx = new System.Windows.Forms.TextBox();
            this.seedlbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.filledcolorbtn = new System.Windows.Forms.Button();
            this.unfilledcolorbtn = new System.Windows.Forms.Button();
            this.bingoamt = new System.Windows.Forms.NumericUpDown();
            this.blackoutchk = new System.Windows.Forms.CheckBox();
            this.bingochk = new System.Windows.Forms.CheckBox();
            this.checkedlbl = new System.Windows.Forms.Label();
            this.uncheckedlbl = new System.Windows.Forms.Label();
            this.seedonlychk = new System.Windows.Forms.CheckBox();
            this.multiplayerchk = new System.Windows.Forms.CheckBox();
            this.dgvbtn = new System.Windows.Forms.Button();
            this.meleechk = new System.Windows.Forms.CheckBox();
            this.rangerchk = new System.Windows.Forms.CheckBox();
            this.magechk = new System.Windows.Forms.CheckBox();
            this.summonerchk = new System.Windows.Forms.CheckBox();
            this.crimsonchk = new System.Windows.Forms.CheckBox();
            this.corruptionchk = new System.Windows.Forms.CheckBox();
            this.clipbtn = new System.Windows.Forms.PictureBox();
            this.difficultyslider = new System.Windows.Forms.TrackBar();
            this.difflbl = new System.Windows.Forms.Label();
            this.diffnum = new System.Windows.Forms.Label();
            this.helpbtn = new System.Windows.Forms.Button();
            this.hardmodechk = new System.Windows.Forms.CheckBox();
            this.prehardmodechk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedtxtcolorlbl = new System.Windows.Forms.Label();
            this.uncheckedtxtcolorbtn = new System.Windows.Forms.Button();
            this.checkedtxtcolorbtn = new System.Windows.Forms.Button();
            this.expertchk = new System.Windows.Forms.CheckBox();
            this.difficultypb = new System.Windows.Forms.PictureBox();
            this.worldpb = new System.Windows.Forms.PictureBox();
            this.expertpb = new System.Windows.Forms.PictureBox();
            this.classlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bingoamt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultypb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertpb)).BeginInit();
            this.SuspendLayout();
            // 
            // freespacechk
            // 
            this.freespacechk.AutoSize = true;
            this.freespacechk.Location = new System.Drawing.Point(375, 280);
            this.freespacechk.Margin = new System.Windows.Forms.Padding(2);
            this.freespacechk.Name = "freespacechk";
            this.freespacechk.Size = new System.Drawing.Size(82, 19);
            this.freespacechk.TabIndex = 0;
            this.freespacechk.Text = "Free Space";
            this.freespacechk.UseVisualStyleBackColor = true;
            // 
            // finishintrobtn
            // 
            this.finishintrobtn.Location = new System.Drawing.Point(253, 334);
            this.finishintrobtn.Margin = new System.Windows.Forms.Padding(2);
            this.finishintrobtn.Name = "finishintrobtn";
            this.finishintrobtn.Size = new System.Drawing.Size(84, 24);
            this.finishintrobtn.TabIndex = 1;
            this.finishintrobtn.Text = "Generate";
            this.finishintrobtn.UseVisualStyleBackColor = true;
            this.finishintrobtn.Click += new System.EventHandler(this.finishintrobtn_Click);
            // 
            // seedtxtbx
            // 
            this.seedtxtbx.Location = new System.Drawing.Point(253, 33);
            this.seedtxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.seedtxtbx.Name = "seedtxtbx";
            this.seedtxtbx.Size = new System.Drawing.Size(106, 23);
            this.seedtxtbx.TabIndex = 2;
            // 
            // seedlbl
            // 
            this.seedlbl.AutoSize = true;
            this.seedlbl.Location = new System.Drawing.Point(221, 16);
            this.seedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seedlbl.Name = "seedlbl";
            this.seedlbl.Size = new System.Drawing.Size(168, 15);
            this.seedlbl.TabIndex = 3;
            this.seedlbl.Text = "Seed (leave blank for random):";
            // 
            // filledcolorbtn
            // 
            this.filledcolorbtn.Location = new System.Drawing.Point(155, 56);
            this.filledcolorbtn.Margin = new System.Windows.Forms.Padding(2);
            this.filledcolorbtn.Name = "filledcolorbtn";
            this.filledcolorbtn.Size = new System.Drawing.Size(78, 20);
            this.filledcolorbtn.TabIndex = 4;
            this.filledcolorbtn.Text = "Select";
            this.filledcolorbtn.UseVisualStyleBackColor = true;
            this.filledcolorbtn.Click += new System.EventHandler(this.filledcolorbtn_Click);
            // 
            // unfilledcolorbtn
            // 
            this.unfilledcolorbtn.Location = new System.Drawing.Point(155, 80);
            this.unfilledcolorbtn.Margin = new System.Windows.Forms.Padding(2);
            this.unfilledcolorbtn.Name = "unfilledcolorbtn";
            this.unfilledcolorbtn.Size = new System.Drawing.Size(78, 20);
            this.unfilledcolorbtn.TabIndex = 5;
            this.unfilledcolorbtn.Text = "Select";
            this.unfilledcolorbtn.UseVisualStyleBackColor = true;
            this.unfilledcolorbtn.Click += new System.EventHandler(this.unfilledcolorbtn_Click);
            // 
            // bingoamt
            // 
            this.bingoamt.Location = new System.Drawing.Point(498, 236);
            this.bingoamt.Margin = new System.Windows.Forms.Padding(2);
            this.bingoamt.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.bingoamt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bingoamt.Name = "bingoamt";
            this.bingoamt.Size = new System.Drawing.Size(36, 23);
            this.bingoamt.TabIndex = 8;
            this.bingoamt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blackoutchk
            // 
            this.blackoutchk.AutoSize = true;
            this.blackoutchk.Location = new System.Drawing.Point(375, 259);
            this.blackoutchk.Margin = new System.Windows.Forms.Padding(2);
            this.blackoutchk.Name = "blackoutchk";
            this.blackoutchk.Size = new System.Drawing.Size(72, 19);
            this.blackoutchk.TabIndex = 9;
            this.blackoutchk.Text = "Blackout";
            this.blackoutchk.UseVisualStyleBackColor = true;
            this.blackoutchk.CheckedChanged += new System.EventHandler(this.blackoutchk_CheckedChanged);
            // 
            // bingochk
            // 
            this.bingochk.AutoSize = true;
            this.bingochk.Checked = true;
            this.bingochk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bingochk.Location = new System.Drawing.Point(375, 238);
            this.bingochk.Margin = new System.Windows.Forms.Padding(2);
            this.bingochk.Name = "bingochk";
            this.bingochk.Size = new System.Drawing.Size(114, 19);
            this.bingochk.TabIndex = 10;
            this.bingochk.Text = "Require x Bingos";
            this.bingochk.UseVisualStyleBackColor = true;
            this.bingochk.CheckedChanged += new System.EventHandler(this.bingochk_CheckedChanged);
            // 
            // checkedlbl
            // 
            this.checkedlbl.AutoSize = true;
            this.checkedlbl.Location = new System.Drawing.Point(8, 56);
            this.checkedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkedlbl.Name = "checkedlbl";
            this.checkedlbl.Size = new System.Drawing.Size(85, 15);
            this.checkedlbl.TabIndex = 11;
            this.checkedlbl.Text = "Checked Color";
            // 
            // uncheckedlbl
            // 
            this.uncheckedlbl.AutoSize = true;
            this.uncheckedlbl.Location = new System.Drawing.Point(8, 80);
            this.uncheckedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uncheckedlbl.Name = "uncheckedlbl";
            this.uncheckedlbl.Size = new System.Drawing.Size(98, 15);
            this.uncheckedlbl.TabIndex = 12;
            this.uncheckedlbl.Text = "Unchecked Color";
            // 
            // seedonlychk
            // 
            this.seedonlychk.AutoSize = true;
            this.seedonlychk.Location = new System.Drawing.Point(375, 301);
            this.seedonlychk.Margin = new System.Windows.Forms.Padding(2);
            this.seedonlychk.Name = "seedonlychk";
            this.seedonlychk.Size = new System.Drawing.Size(180, 19);
            this.seedonlychk.TabIndex = 13;
            this.seedonlychk.Text = "Generate Only Seed (no card)";
            this.seedonlychk.UseVisualStyleBackColor = true;
            // 
            // multiplayerchk
            // 
            this.multiplayerchk.AutoSize = true;
            this.multiplayerchk.Location = new System.Drawing.Point(253, 301);
            this.multiplayerchk.Margin = new System.Windows.Forms.Padding(2);
            this.multiplayerchk.Name = "multiplayerchk";
            this.multiplayerchk.Size = new System.Drawing.Size(86, 19);
            this.multiplayerchk.TabIndex = 14;
            this.multiplayerchk.Text = "Multiplayer";
            this.multiplayerchk.UseVisualStyleBackColor = true;
            // 
            // dgvbtn
            // 
            this.dgvbtn.Location = new System.Drawing.Point(472, 334);
            this.dgvbtn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvbtn.Name = "dgvbtn";
            this.dgvbtn.Size = new System.Drawing.Size(84, 24);
            this.dgvbtn.TabIndex = 15;
            this.dgvbtn.Text = "Show Table";
            this.dgvbtn.UseVisualStyleBackColor = true;
            this.dgvbtn.Click += new System.EventHandler(this.dgvbtn_Click);
            // 
            // meleechk
            // 
            this.meleechk.AutoSize = true;
            this.meleechk.Location = new System.Drawing.Point(111, 237);
            this.meleechk.Margin = new System.Windows.Forms.Padding(2);
            this.meleechk.Name = "meleechk";
            this.meleechk.Size = new System.Drawing.Size(58, 19);
            this.meleechk.TabIndex = 16;
            this.meleechk.Text = "Melee";
            this.meleechk.UseVisualStyleBackColor = true;
            // 
            // rangerchk
            // 
            this.rangerchk.AutoSize = true;
            this.rangerchk.Location = new System.Drawing.Point(111, 258);
            this.rangerchk.Margin = new System.Windows.Forms.Padding(2);
            this.rangerchk.Name = "rangerchk";
            this.rangerchk.Size = new System.Drawing.Size(63, 19);
            this.rangerchk.TabIndex = 17;
            this.rangerchk.Text = "Ranger";
            this.rangerchk.UseVisualStyleBackColor = true;
            // 
            // magechk
            // 
            this.magechk.AutoSize = true;
            this.magechk.Location = new System.Drawing.Point(111, 279);
            this.magechk.Margin = new System.Windows.Forms.Padding(2);
            this.magechk.Name = "magechk";
            this.magechk.Size = new System.Drawing.Size(56, 19);
            this.magechk.TabIndex = 18;
            this.magechk.Text = "Mage";
            this.magechk.UseVisualStyleBackColor = true;
            // 
            // summonerchk
            // 
            this.summonerchk.AutoSize = true;
            this.summonerchk.Location = new System.Drawing.Point(111, 300);
            this.summonerchk.Margin = new System.Windows.Forms.Padding(2);
            this.summonerchk.Name = "summonerchk";
            this.summonerchk.Size = new System.Drawing.Size(85, 19);
            this.summonerchk.TabIndex = 19;
            this.summonerchk.Text = "Summoner";
            this.summonerchk.UseVisualStyleBackColor = true;
            // 
            // crimsonchk
            // 
            this.crimsonchk.AutoSize = true;
            this.crimsonchk.BackColor = System.Drawing.SystemColors.Control;
            this.crimsonchk.Checked = true;
            this.crimsonchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crimsonchk.Location = new System.Drawing.Point(253, 238);
            this.crimsonchk.Margin = new System.Windows.Forms.Padding(2);
            this.crimsonchk.Name = "crimsonchk";
            this.crimsonchk.Size = new System.Drawing.Size(71, 19);
            this.crimsonchk.TabIndex = 20;
            this.crimsonchk.Text = "Crimson";
            this.crimsonchk.UseVisualStyleBackColor = false;
            this.crimsonchk.CheckedChanged += new System.EventHandler(this.crimsonchk_CheckedChanged);
            // 
            // corruptionchk
            // 
            this.corruptionchk.AutoSize = true;
            this.corruptionchk.Location = new System.Drawing.Point(253, 257);
            this.corruptionchk.Margin = new System.Windows.Forms.Padding(2);
            this.corruptionchk.Name = "corruptionchk";
            this.corruptionchk.Size = new System.Drawing.Size(84, 19);
            this.corruptionchk.TabIndex = 21;
            this.corruptionchk.Text = "Corruption";
            this.corruptionchk.UseVisualStyleBackColor = true;
            this.corruptionchk.CheckedChanged += new System.EventHandler(this.corruptionchk_CheckedChanged);
            // 
            // clipbtn
            // 
            this.clipbtn.Location = new System.Drawing.Point(362, 33);
            this.clipbtn.Margin = new System.Windows.Forms.Padding(2);
            this.clipbtn.Name = "clipbtn";
            this.clipbtn.Size = new System.Drawing.Size(22, 19);
            this.clipbtn.TabIndex = 22;
            this.clipbtn.TabStop = false;
            this.clipbtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // difficultyslider
            // 
            this.difficultyslider.Location = new System.Drawing.Point(396, 80);
            this.difficultyslider.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyslider.Maximum = 4;
            this.difficultyslider.Minimum = 1;
            this.difficultyslider.Name = "difficultyslider";
            this.difficultyslider.Size = new System.Drawing.Size(109, 45);
            this.difficultyslider.TabIndex = 23;
            this.difficultyslider.Value = 1;
            this.difficultyslider.Scroll += new System.EventHandler(this.difficultyslider_Scroll);
            // 
            // difflbl
            // 
            this.difflbl.AutoSize = true;
            this.difflbl.Location = new System.Drawing.Point(265, 82);
            this.difflbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.difflbl.Name = "difflbl";
            this.difflbl.Size = new System.Drawing.Size(58, 15);
            this.difflbl.TabIndex = 24;
            this.difflbl.Text = "Difficulty:";
            // 
            // diffnum
            // 
            this.diffnum.AutoSize = true;
            this.diffnum.Location = new System.Drawing.Point(325, 82);
            this.diffnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diffnum.Name = "diffnum";
            this.diffnum.Size = new System.Drawing.Size(30, 15);
            this.diffnum.TabIndex = 25;
            this.diffnum.Text = "Easy";
            // 
            // helpbtn
            // 
            this.helpbtn.Location = new System.Drawing.Point(427, 32);
            this.helpbtn.Margin = new System.Windows.Forms.Padding(2);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(78, 24);
            this.helpbtn.TabIndex = 26;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // hardmodechk
            // 
            this.hardmodechk.AutoSize = true;
            this.hardmodechk.Checked = true;
            this.hardmodechk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hardmodechk.Location = new System.Drawing.Point(253, 217);
            this.hardmodechk.Margin = new System.Windows.Forms.Padding(2);
            this.hardmodechk.Name = "hardmodechk";
            this.hardmodechk.Size = new System.Drawing.Size(83, 19);
            this.hardmodechk.TabIndex = 27;
            this.hardmodechk.Text = "Hardmode";
            this.hardmodechk.UseVisualStyleBackColor = true;
            this.hardmodechk.CheckedChanged += new System.EventHandler(this.hardmodechk_CheckedChanged);
            // 
            // prehardmodechk
            // 
            this.prehardmodechk.AutoSize = true;
            this.prehardmodechk.Checked = true;
            this.prehardmodechk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prehardmodechk.Location = new System.Drawing.Point(253, 196);
            this.prehardmodechk.Margin = new System.Windows.Forms.Padding(2);
            this.prehardmodechk.Name = "prehardmodechk";
            this.prehardmodechk.Size = new System.Drawing.Size(105, 19);
            this.prehardmodechk.TabIndex = 28;
            this.prehardmodechk.Text = "Pre-Hardmode";
            this.prehardmodechk.UseVisualStyleBackColor = true;
            this.prehardmodechk.CheckedChanged += new System.EventHandler(this.prehardmodechk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Unchecked Text Color";
            // 
            // checkedtxtcolorlbl
            // 
            this.checkedtxtcolorlbl.AutoSize = true;
            this.checkedtxtcolorlbl.Location = new System.Drawing.Point(8, 104);
            this.checkedtxtcolorlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkedtxtcolorlbl.Name = "checkedtxtcolorlbl";
            this.checkedtxtcolorlbl.Size = new System.Drawing.Size(112, 15);
            this.checkedtxtcolorlbl.TabIndex = 31;
            this.checkedtxtcolorlbl.Text = "Checked  Text Color";
            // 
            // uncheckedtxtcolorbtn
            // 
            this.uncheckedtxtcolorbtn.Location = new System.Drawing.Point(155, 128);
            this.uncheckedtxtcolorbtn.Margin = new System.Windows.Forms.Padding(2);
            this.uncheckedtxtcolorbtn.Name = "uncheckedtxtcolorbtn";
            this.uncheckedtxtcolorbtn.Size = new System.Drawing.Size(78, 20);
            this.uncheckedtxtcolorbtn.TabIndex = 30;
            this.uncheckedtxtcolorbtn.Text = "Select";
            this.uncheckedtxtcolorbtn.UseVisualStyleBackColor = true;
            this.uncheckedtxtcolorbtn.Click += new System.EventHandler(this.uncheckedtxtcolorbtn_Click);
            // 
            // checkedtxtcolorbtn
            // 
            this.checkedtxtcolorbtn.Location = new System.Drawing.Point(155, 104);
            this.checkedtxtcolorbtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkedtxtcolorbtn.Name = "checkedtxtcolorbtn";
            this.checkedtxtcolorbtn.Size = new System.Drawing.Size(78, 20);
            this.checkedtxtcolorbtn.TabIndex = 29;
            this.checkedtxtcolorbtn.Text = "Select";
            this.checkedtxtcolorbtn.UseVisualStyleBackColor = true;
            this.checkedtxtcolorbtn.Click += new System.EventHandler(this.checkedtxtcolorbtn_Click);
            // 
            // expertchk
            // 
            this.expertchk.AutoSize = true;
            this.expertchk.Location = new System.Drawing.Point(375, 196);
            this.expertchk.Margin = new System.Windows.Forms.Padding(2);
            this.expertchk.Name = "expertchk";
            this.expertchk.Size = new System.Drawing.Size(59, 19);
            this.expertchk.TabIndex = 33;
            this.expertchk.Text = "Expert";
            this.expertchk.UseVisualStyleBackColor = true;
            this.expertchk.CheckedChanged += new System.EventHandler(this.expertchk_CheckedChanged);
            // 
            // difficultypb
            // 
            this.difficultypb.Location = new System.Drawing.Point(512, 70);
            this.difficultypb.Margin = new System.Windows.Forms.Padding(2);
            this.difficultypb.Name = "difficultypb";
            this.difficultypb.Size = new System.Drawing.Size(45, 38);
            this.difficultypb.TabIndex = 34;
            this.difficultypb.TabStop = false;
            // 
            // worldpb
            // 
            this.worldpb.Location = new System.Drawing.Point(259, 115);
            this.worldpb.Margin = new System.Windows.Forms.Padding(2);
            this.worldpb.Name = "worldpb";
            this.worldpb.Size = new System.Drawing.Size(90, 77);
            this.worldpb.TabIndex = 35;
            this.worldpb.TabStop = false;
            // 
            // expertpb
            // 
            this.expertpb.Location = new System.Drawing.Point(348, 115);
            this.expertpb.Margin = new System.Windows.Forms.Padding(2);
            this.expertpb.Name = "expertpb";
            this.expertpb.Size = new System.Drawing.Size(25, 31);
            this.expertpb.TabIndex = 36;
            this.expertpb.TabStop = false;
            // 
            // classlbl
            // 
            this.classlbl.AutoSize = true;
            this.classlbl.Location = new System.Drawing.Point(111, 217);
            this.classlbl.Name = "classlbl";
            this.classlbl.Size = new System.Drawing.Size(61, 15);
            this.classlbl.TabIndex = 37;
            this.classlbl.Text = "Class Pool";
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 385);
            this.Controls.Add(this.classlbl);
            this.Controls.Add(this.expertpb);
            this.Controls.Add(this.worldpb);
            this.Controls.Add(this.difficultypb);
            this.Controls.Add(this.expertchk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedtxtcolorlbl);
            this.Controls.Add(this.uncheckedtxtcolorbtn);
            this.Controls.Add(this.checkedtxtcolorbtn);
            this.Controls.Add(this.prehardmodechk);
            this.Controls.Add(this.hardmodechk);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.diffnum);
            this.Controls.Add(this.difflbl);
            this.Controls.Add(this.difficultyslider);
            this.Controls.Add(this.clipbtn);
            this.Controls.Add(this.corruptionchk);
            this.Controls.Add(this.crimsonchk);
            this.Controls.Add(this.summonerchk);
            this.Controls.Add(this.magechk);
            this.Controls.Add(this.rangerchk);
            this.Controls.Add(this.meleechk);
            this.Controls.Add(this.dgvbtn);
            this.Controls.Add(this.multiplayerchk);
            this.Controls.Add(this.seedonlychk);
            this.Controls.Add(this.uncheckedlbl);
            this.Controls.Add(this.checkedlbl);
            this.Controls.Add(this.bingochk);
            this.Controls.Add(this.blackoutchk);
            this.Controls.Add(this.bingoamt);
            this.Controls.Add(this.unfilledcolorbtn);
            this.Controls.Add(this.filledcolorbtn);
            this.Controls.Add(this.seedlbl);
            this.Controls.Add(this.seedtxtbx);
            this.Controls.Add(this.finishintrobtn);
            this.Controls.Add(this.freespacechk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Intro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bingoamt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultypb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox freespacechk;
        private Button finishintrobtn;
        private TextBox seedtxtbx;
        private Label seedlbl;
        private ColorDialog colorDialog1;
        private Button filledcolorbtn;
        private Button unfilledcolorbtn;
        private NumericUpDown bingoamt;
        private CheckBox blackoutchk;
        private CheckBox bingochk;
        private Label checkedlbl;
        private Label uncheckedlbl;
        private CheckBox seedonlychk;
        private CheckBox multiplayerchk;
        private Button dgvbtn;
        private CheckBox meleechk;
        private CheckBox rangerchk;
        private CheckBox magechk;
        private CheckBox summonerchk;
        private CheckBox crimsonchk;
        private CheckBox corruptionchk;
        private PictureBox clipbtn;
        private TrackBar difficultyslider;
        private Label difflbl;
        private Label diffnum;
        private Button helpbtn;
        private CheckBox hardmodechk;
        private CheckBox prehardmodechk;
        private Label label2;
        private Label checkedtxtcolorlbl;
        private Button uncheckedtxtcolorbtn;
        private Button checkedtxtcolorbtn;
        private CheckBox expertchk;
        private PictureBox difficultypb;
        private PictureBox worldpb;
        private PictureBox expertpb;
        private Label classlbl;
    }
}