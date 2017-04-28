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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPBox = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.hammerheadBridgeBox = new System.Windows.Forms.CheckBox();
            this.flounderHeightsBox = new System.Windows.Forms.CheckBox();
            this.campTriggerfishBox = new System.Windows.Forms.CheckBox();
            this.bluefinDepotBox = new System.Windows.Forms.CheckBox();
            this.blackBellySkateparkBox = new System.Windows.Forms.CheckBox();
            this.arowanaMallBox = new System.Windows.Forms.CheckBox();
            this.anchovGamesBox = new System.Windows.Forms.CheckBox();
            this.buttonPoke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(7, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(110, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect to Gecko";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconn);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 51);
            this.groupBox1.TabIndex = 4;
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
            this.buttonDisconn.Click += new System.EventHandler(this.buttonDisconn_Click);
            // 
            // groupBox2
            // 
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
            this.groupBox2.Controls.Add(this.hammerheadBridgeBox);
            this.groupBox2.Controls.Add(this.flounderHeightsBox);
            this.groupBox2.Controls.Add(this.campTriggerfishBox);
            this.groupBox2.Controls.Add(this.bluefinDepotBox);
            this.groupBox2.Controls.Add(this.blackBellySkateparkBox);
            this.groupBox2.Controls.Add(this.arowanaMallBox);
            this.groupBox2.Controls.Add(this.anchovGamesBox);
            this.groupBox2.Controls.Add(this.buttonPoke);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(7, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 238);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // toggleAll
            // 
            this.toggleAll.Location = new System.Drawing.Point(87, 207);
            this.toggleAll.Name = "toggleAll";
            this.toggleAll.Size = new System.Drawing.Size(123, 23);
            this.toggleAll.TabIndex = 44;
            this.toggleAll.Text = "Toggle all checkboxes";
            this.toggleAll.UseVisualStyleBackColor = true;
            this.toggleAll.Click += new System.EventHandler(this.toggleAll_Click);
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
            this.museumDalfonsinoBox.Size = new System.Drawing.Size(119, 17);
            this.museumDalfonsinoBox.TabIndex = 38;
            this.museumDalfonsinoBox.Text = "Museum Dalfonsino";
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
            this.mahimahiResortBox.Size = new System.Drawing.Size(105, 17);
            this.mahimahiResortBox.TabIndex = 36;
            this.mahimahiResortBox.Text = "Mahimahi Resort";
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
            // hammerheadBridgeBox
            // 
            this.hammerheadBridgeBox.AutoSize = true;
            this.hammerheadBridgeBox.Location = new System.Drawing.Point(15, 162);
            this.hammerheadBridgeBox.Name = "hammerheadBridgeBox";
            this.hammerheadBridgeBox.Size = new System.Drawing.Size(122, 17);
            this.hammerheadBridgeBox.TabIndex = 34;
            this.hammerheadBridgeBox.Text = "Hammerhead Bridge";
            this.hammerheadBridgeBox.UseVisualStyleBackColor = true;
            this.hammerheadBridgeBox.CheckedChanged += new System.EventHandler(this.hammerheadBridgeBox_CheckedChanged);
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
            this.anchovGamesBox.Text = "Ancho-V-Games";
            this.anchovGamesBox.UseVisualStyleBackColor = true;
            // 
            // buttonPoke
            // 
            this.buttonPoke.Location = new System.Drawing.Point(215, 207);
            this.buttonPoke.Name = "buttonPoke";
            this.buttonPoke.Size = new System.Drawing.Size(75, 23);
            this.buttonPoke.TabIndex = 11;
            this.buttonPoke.Text = "Poke";
            this.buttonPoke.UseVisualStyleBackColor = true;
            this.buttonPoke.Click += new System.EventHandler(this.buttonPoke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(71, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OatmealDome, Bkool999, Yahya14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 326);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDisconn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPoke;
        private System.Windows.Forms.CheckBox walleyeWarehouseBox;
        private System.Windows.Forms.CheckBox urchinUnderpassBox;
        private System.Windows.Forms.CheckBox saltsprayRigBox;
        private System.Windows.Forms.CheckBox portMackerelBox;
        private System.Windows.Forms.CheckBox piranhaPitBox;
        private System.Windows.Forms.CheckBox museumDalfonsinoBox;
        private System.Windows.Forms.CheckBox morayTowersBox;
        private System.Windows.Forms.CheckBox mahimahiResortBox;
        private System.Windows.Forms.CheckBox kelpDomeBox;
        private System.Windows.Forms.CheckBox hammerheadBridgeBox;
        private System.Windows.Forms.CheckBox flounderHeightsBox;
        private System.Windows.Forms.CheckBox campTriggerfishBox;
        private System.Windows.Forms.CheckBox bluefinDepotBox;
        private System.Windows.Forms.CheckBox blackBellySkateparkBox;
        private System.Windows.Forms.CheckBox arowanaMallBox;
        private System.Windows.Forms.CheckBox anchovGamesBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button toggleAll;
    }
}

