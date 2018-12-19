namespace SafeNightPatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mapCheckerTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMusicPoke = new System.Windows.Forms.Button();
            this.cmbMusic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hammerheadBridgeBox = new System.Windows.Forms.CheckBox();
            this.toggleAll = new System.Windows.Forms.Button();
            this.walleyeWarehouseBox = new System.Windows.Forms.CheckBox();
            this.urchinUnderpassBox = new System.Windows.Forms.CheckBox();
            this.saltsprayRigBox = new System.Windows.Forms.CheckBox();
            this.portMackerelBox = new System.Windows.Forms.CheckBox();
            this.piranhaPitBox = new System.Windows.Forms.CheckBox();
            this.museumDalfonsinoBox = new System.Windows.Forms.CheckBox();
            this.morayTowersBox = new System.Windows.Forms.CheckBox();
            this.mahimahiResortBox = new System.Windows.Forms.CheckBox();
            this.kelpDomeBox = new System.Windows.Forms.CheckBox();
            this.hammerheadBridgeOrBox = new System.Windows.Forms.CheckBox();
            this.flounderHeightsBox = new System.Windows.Forms.CheckBox();
            this.campTriggerfishBox = new System.Windows.Forms.CheckBox();
            this.bluefinDepotBox = new System.Windows.Forms.CheckBox();
            this.blackBellySkateparkBox = new System.Windows.Forms.CheckBox();
            this.arowanaMallBox = new System.Windows.Forms.CheckBox();
            this.anchovGamesBox = new System.Windows.Forms.CheckBox();
            this.buttonPoke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconn = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ObjectTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapCheckerTimer
            // 
            this.mapCheckerTimer.Interval = 50;
            this.mapCheckerTimer.Tick += new System.EventHandler(this.mapCheckerTimer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(7, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 44);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automatic poking config";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Automatically poke stages and music";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMusicPoke);
            this.groupBox3.Controls.Add(this.cmbMusic);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(7, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 47);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Music";
            // 
            // btnMusicPoke
            // 
            this.btnMusicPoke.Location = new System.Drawing.Point(215, 16);
            this.btnMusicPoke.Name = "btnMusicPoke";
            this.btnMusicPoke.Size = new System.Drawing.Size(75, 23);
            this.btnMusicPoke.TabIndex = 9;
            this.btnMusicPoke.Text = "Poke music";
            this.btnMusicPoke.UseVisualStyleBackColor = true;
            // 
            // cmbMusic
            // 
            this.cmbMusic.FormattingEnabled = true;
            this.cmbMusic.Items.AddRange(new object[] {
            "None",
            "Ink me up",
            "Calamari Inkantation"});
            this.cmbMusic.Location = new System.Drawing.Point(7, 17);
            this.cmbMusic.Name = "cmbMusic";
            this.cmbMusic.Size = new System.Drawing.Size(202, 21);
            this.cmbMusic.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(71, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "OatmealDome, Bkool999, Yahya14";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.hammerheadBridgeBox);
            this.groupBox2.Controls.Add(this.toggleAll);
            this.groupBox2.Controls.Add(this.walleyeWarehouseBox);
            this.groupBox2.Controls.Add(this.urchinUnderpassBox);
            this.groupBox2.Controls.Add(this.saltsprayRigBox);
            this.groupBox2.Controls.Add(this.portMackerelBox);
            this.groupBox2.Controls.Add(this.piranhaPitBox);
            this.groupBox2.Controls.Add(this.museumDalfonsinoBox);
            this.groupBox2.Controls.Add(this.morayTowersBox);
            this.groupBox2.Controls.Add(this.mahimahiResortBox);
            this.groupBox2.Controls.Add(this.kelpDomeBox);
            this.groupBox2.Controls.Add(this.hammerheadBridgeOrBox);
            this.groupBox2.Controls.Add(this.flounderHeightsBox);
            this.groupBox2.Controls.Add(this.campTriggerfishBox);
            this.groupBox2.Controls.Add(this.bluefinDepotBox);
            this.groupBox2.Controls.Add(this.blackBellySkateparkBox);
            this.groupBox2.Controls.Add(this.arowanaMallBox);
            this.groupBox2.Controls.Add(this.anchovGamesBox);
            this.groupBox2.Controls.Add(this.buttonPoke);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(7, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 275);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "______________________________________________";
            // 
            // hammerheadBridgeBox
            // 
            this.hammerheadBridgeBox.AutoSize = true;
            this.hammerheadBridgeBox.Location = new System.Drawing.Point(15, 161);
            this.hammerheadBridgeBox.Name = "hammerheadBridgeBox";
            this.hammerheadBridgeBox.Size = new System.Drawing.Size(122, 17);
            this.hammerheadBridgeBox.TabIndex = 45;
            this.hammerheadBridgeBox.Text = "Hammerhead Bridge";
            this.hammerheadBridgeBox.UseVisualStyleBackColor = true;
            // 
            // toggleAll
            // 
            this.toggleAll.Location = new System.Drawing.Point(87, 246);
            this.toggleAll.Name = "toggleAll";
            this.toggleAll.Size = new System.Drawing.Size(123, 23);
            this.toggleAll.TabIndex = 44;
            this.toggleAll.Text = "Toggle all checkboxes";
            this.toggleAll.UseVisualStyleBackColor = true;
            // 
            // walleyeWarehouseBox
            // 
            this.walleyeWarehouseBox.AutoSize = true;
            this.walleyeWarehouseBox.Location = new System.Drawing.Point(165, 184);
            this.walleyeWarehouseBox.Name = "walleyeWarehouseBox";
            this.walleyeWarehouseBox.Size = new System.Drawing.Size(122, 17);
            this.walleyeWarehouseBox.TabIndex = 43;
            this.walleyeWarehouseBox.Text = "Walleye Warehouse";
            this.walleyeWarehouseBox.UseVisualStyleBackColor = true;
            // 
            // urchinUnderpassBox
            // 
            this.urchinUnderpassBox.AutoSize = true;
            this.urchinUnderpassBox.Location = new System.Drawing.Point(165, 161);
            this.urchinUnderpassBox.Name = "urchinUnderpassBox";
            this.urchinUnderpassBox.Size = new System.Drawing.Size(111, 17);
            this.urchinUnderpassBox.TabIndex = 42;
            this.urchinUnderpassBox.Text = "Urchin Underpass";
            this.urchinUnderpassBox.UseVisualStyleBackColor = true;
            // 
            // saltsprayRigBox
            // 
            this.saltsprayRigBox.AutoSize = true;
            this.saltsprayRigBox.Location = new System.Drawing.Point(165, 138);
            this.saltsprayRigBox.Name = "saltsprayRigBox";
            this.saltsprayRigBox.Size = new System.Drawing.Size(88, 17);
            this.saltsprayRigBox.TabIndex = 41;
            this.saltsprayRigBox.Text = "Saltspray Rig";
            this.saltsprayRigBox.UseVisualStyleBackColor = true;
            // 
            // portMackerelBox
            // 
            this.portMackerelBox.AutoSize = true;
            this.portMackerelBox.Location = new System.Drawing.Point(165, 116);
            this.portMackerelBox.Name = "portMackerelBox";
            this.portMackerelBox.Size = new System.Drawing.Size(92, 17);
            this.portMackerelBox.TabIndex = 40;
            this.portMackerelBox.Text = "Port Mackerel";
            this.portMackerelBox.UseVisualStyleBackColor = true;
            // 
            // piranhaPitBox
            // 
            this.piranhaPitBox.AutoSize = true;
            this.piranhaPitBox.Location = new System.Drawing.Point(165, 94);
            this.piranhaPitBox.Name = "piranhaPitBox";
            this.piranhaPitBox.Size = new System.Drawing.Size(77, 17);
            this.piranhaPitBox.TabIndex = 39;
            this.piranhaPitBox.Text = "Piranha Pit";
            this.piranhaPitBox.UseVisualStyleBackColor = true;
            // 
            // museumDalfonsinoBox
            // 
            this.museumDalfonsinoBox.AutoSize = true;
            this.museumDalfonsinoBox.Location = new System.Drawing.Point(165, 71);
            this.museumDalfonsinoBox.Name = "museumDalfonsinoBox";
            this.museumDalfonsinoBox.Size = new System.Drawing.Size(120, 17);
            this.museumDalfonsinoBox.TabIndex = 38;
            this.museumDalfonsinoBox.Text = "Museum d\'Alfonsino";
            this.museumDalfonsinoBox.UseVisualStyleBackColor = true;
            // 
            // morayTowersBox
            // 
            this.morayTowersBox.AutoSize = true;
            this.morayTowersBox.Location = new System.Drawing.Point(165, 48);
            this.morayTowersBox.Name = "morayTowersBox";
            this.morayTowersBox.Size = new System.Drawing.Size(93, 17);
            this.morayTowersBox.TabIndex = 37;
            this.morayTowersBox.Text = "Moray Towers";
            this.morayTowersBox.UseVisualStyleBackColor = true;
            // 
            // mahimahiResortBox
            // 
            this.mahimahiResortBox.AutoSize = true;
            this.mahimahiResortBox.Location = new System.Drawing.Point(165, 25);
            this.mahimahiResortBox.Name = "mahimahiResortBox";
            this.mahimahiResortBox.Size = new System.Drawing.Size(109, 17);
            this.mahimahiResortBox.TabIndex = 36;
            this.mahimahiResortBox.Text = "Mahi-Mahi Resort";
            this.mahimahiResortBox.UseVisualStyleBackColor = true;
            // 
            // kelpDomeBox
            // 
            this.kelpDomeBox.AutoSize = true;
            this.kelpDomeBox.Location = new System.Drawing.Point(15, 185);
            this.kelpDomeBox.Name = "kelpDomeBox";
            this.kelpDomeBox.Size = new System.Drawing.Size(78, 17);
            this.kelpDomeBox.TabIndex = 35;
            this.kelpDomeBox.Text = "Kelp Dome";
            this.kelpDomeBox.UseVisualStyleBackColor = true;
            // 
            // hammerheadBridgeOrBox
            // 
            this.hammerheadBridgeOrBox.AutoSize = true;
            this.hammerheadBridgeOrBox.Location = new System.Drawing.Point(15, 223);
            this.hammerheadBridgeOrBox.Name = "hammerheadBridgeOrBox";
            this.hammerheadBridgeOrBox.Size = new System.Drawing.Size(202, 17);
            this.hammerheadBridgeOrBox.TabIndex = 34;
            this.hammerheadBridgeOrBox.Text = "Hammerhead Bridge (Unsafe version)";
            this.hammerheadBridgeOrBox.UseVisualStyleBackColor = true;
            // 
            // flounderHeightsBox
            // 
            this.flounderHeightsBox.AutoSize = true;
            this.flounderHeightsBox.Location = new System.Drawing.Point(15, 139);
            this.flounderHeightsBox.Name = "flounderHeightsBox";
            this.flounderHeightsBox.Size = new System.Drawing.Size(106, 17);
            this.flounderHeightsBox.TabIndex = 33;
            this.flounderHeightsBox.Text = "Flounder Heights";
            this.flounderHeightsBox.UseVisualStyleBackColor = true;
            // 
            // campTriggerfishBox
            // 
            this.campTriggerfishBox.AutoSize = true;
            this.campTriggerfishBox.Location = new System.Drawing.Point(15, 116);
            this.campTriggerfishBox.Name = "campTriggerfishBox";
            this.campTriggerfishBox.Size = new System.Drawing.Size(105, 17);
            this.campTriggerfishBox.TabIndex = 32;
            this.campTriggerfishBox.Text = "Camp Triggerfish";
            this.campTriggerfishBox.UseVisualStyleBackColor = true;
            // 
            // bluefinDepotBox
            // 
            this.bluefinDepotBox.AutoSize = true;
            this.bluefinDepotBox.Location = new System.Drawing.Point(15, 93);
            this.bluefinDepotBox.Name = "bluefinDepotBox";
            this.bluefinDepotBox.Size = new System.Drawing.Size(90, 17);
            this.bluefinDepotBox.TabIndex = 31;
            this.bluefinDepotBox.Text = "Bluefin Depot";
            this.bluefinDepotBox.UseVisualStyleBackColor = true;
            // 
            // blackBellySkateparkBox
            // 
            this.blackBellySkateparkBox.AutoSize = true;
            this.blackBellySkateparkBox.Location = new System.Drawing.Point(15, 70);
            this.blackBellySkateparkBox.Name = "blackBellySkateparkBox";
            this.blackBellySkateparkBox.Size = new System.Drawing.Size(126, 17);
            this.blackBellySkateparkBox.TabIndex = 30;
            this.blackBellySkateparkBox.Text = "Blackbelly Skatepark";
            this.blackBellySkateparkBox.UseVisualStyleBackColor = true;
            // 
            // arowanaMallBox
            // 
            this.arowanaMallBox.AutoSize = true;
            this.arowanaMallBox.Location = new System.Drawing.Point(15, 47);
            this.arowanaMallBox.Name = "arowanaMallBox";
            this.arowanaMallBox.Size = new System.Drawing.Size(90, 17);
            this.arowanaMallBox.TabIndex = 29;
            this.arowanaMallBox.Text = "Arowana Mall";
            this.arowanaMallBox.UseVisualStyleBackColor = true;
            // 
            // anchovGamesBox
            // 
            this.anchovGamesBox.AutoSize = true;
            this.anchovGamesBox.Location = new System.Drawing.Point(15, 24);
            this.anchovGamesBox.Name = "anchovGamesBox";
            this.anchovGamesBox.Size = new System.Drawing.Size(103, 17);
            this.anchovGamesBox.TabIndex = 28;
            this.anchovGamesBox.Text = "Ancho-V Games";
            this.anchovGamesBox.UseVisualStyleBackColor = true;
            // 
            // buttonPoke
            // 
            this.buttonPoke.Location = new System.Drawing.Point(215, 246);
            this.buttonPoke.Name = "buttonPoke";
            this.buttonPoke.Size = new System.Drawing.Size(75, 23);
            this.buttonPoke.TabIndex = 11;
            this.buttonPoke.Text = "Poke";
            this.buttonPoke.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconn);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPGecko/Geckiine Connection";
            // 
            // buttonDisconn
            // 
            this.buttonDisconn.Enabled = false;
            this.buttonDisconn.Location = new System.Drawing.Point(221, 17);
            this.buttonDisconn.Name = "buttonDisconn";
            this.buttonDisconn.Size = new System.Drawing.Size(70, 23);
            this.buttonDisconn.TabIndex = 2;
            this.buttonDisconn.Text = "Disconnect";
            this.buttonDisconn.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(110, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect to Gecko";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(7, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 0;
            // 
            // ObjectTimer
            // 
            this.ObjectTimer.Interval = 3000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 467);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Safe NightPatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer mapCheckerTimer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMusicPoke;
        private System.Windows.Forms.ComboBox cmbMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hammerheadBridgeBox;
        private System.Windows.Forms.Button toggleAll;
        private System.Windows.Forms.CheckBox walleyeWarehouseBox;
        private System.Windows.Forms.CheckBox urchinUnderpassBox;
        private System.Windows.Forms.CheckBox saltsprayRigBox;
        private System.Windows.Forms.CheckBox portMackerelBox;
        private System.Windows.Forms.CheckBox piranhaPitBox;
        private System.Windows.Forms.CheckBox museumDalfonsinoBox;
        private System.Windows.Forms.CheckBox morayTowersBox;
        private System.Windows.Forms.CheckBox mahimahiResortBox;
        private System.Windows.Forms.CheckBox kelpDomeBox;
        private System.Windows.Forms.CheckBox hammerheadBridgeOrBox;
        private System.Windows.Forms.CheckBox flounderHeightsBox;
        private System.Windows.Forms.CheckBox campTriggerfishBox;
        private System.Windows.Forms.CheckBox bluefinDepotBox;
        private System.Windows.Forms.CheckBox blackBellySkateparkBox;
        private System.Windows.Forms.CheckBox arowanaMallBox;
        private System.Windows.Forms.CheckBox anchovGamesBox;
        private System.Windows.Forms.Button buttonPoke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDisconn;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Timer ObjectTimer;
    }
}

