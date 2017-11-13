namespace DominikSlawkowskiLab1
{
    partial class FormHomework1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomework1));
            this.panelBackgound = new System.Windows.Forms.Panel();
            this.dataGridViewResources = new System.Windows.Forms.DataGridView();
            this.labelKingdomName = new System.Windows.Forms.Label();
            this.pictureBoxMint = new System.Windows.Forms.PictureBox();
            this.pictureBoxMine = new System.Windows.Forms.PictureBox();
            this.pictureBoxBaker = new System.Windows.Forms.PictureBox();
            this.pictureBoxSawmill = new System.Windows.Forms.PictureBox();
            this.timerGoldIncrease = new System.Windows.Forms.Timer(this.components);
            this.timerWoodIncrease = new System.Windows.Forms.Timer(this.components);
            this.timerStoneIncrease = new System.Windows.Forms.Timer(this.components);
            this.timerFoodIncrease = new System.Windows.Forms.Timer(this.components);
            this.panelDownBackgroung = new System.Windows.Forms.Panel();
            this.labelSawmillLevel = new System.Windows.Forms.Label();
            this.labelMintLevel = new System.Windows.Forms.Label();
            this.buttonMintUpgrade = new System.Windows.Forms.Button();
            this.labelMineLevel = new System.Windows.Forms.Label();
            this.labelBakerLevel = new System.Windows.Forms.Label();
            this.buttonMineUpgrade = new System.Windows.Forms.Button();
            this.buttonSawmillUpgrade = new System.Windows.Forms.Button();
            this.buttonBakerUpgrade = new System.Windows.Forms.Button();
            this.labelBakerUpgradeCost = new System.Windows.Forms.Label();
            this.labelMintUpgradeCost = new System.Windows.Forms.Label();
            this.labelMineUpgradeCost = new System.Windows.Forms.Label();
            this.labelSawmillUpgradeCost = new System.Windows.Forms.Label();
            this.buttonFire = new System.Windows.Forms.Button();
            this.panelBackgound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSawmill)).BeginInit();
            this.panelDownBackgroung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackgound
            // 
            this.panelBackgound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackgound.BackgroundImage")));
            this.panelBackgound.Controls.Add(this.buttonFire);
            this.panelBackgound.Controls.Add(this.dataGridViewResources);
            this.panelBackgound.Controls.Add(this.labelKingdomName);
            this.panelBackgound.Location = new System.Drawing.Point(0, 0);
            this.panelBackgound.Name = "panelBackgound";
            this.panelBackgound.Size = new System.Drawing.Size(795, 431);
            this.panelBackgound.TabIndex = 0;
            // 
            // dataGridViewResources
            // 
            this.dataGridViewResources.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResources.Location = new System.Drawing.Point(318, 12);
            this.dataGridViewResources.Name = "dataGridViewResources";
            this.dataGridViewResources.ReadOnly = true;
            this.dataGridViewResources.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewResources.Size = new System.Drawing.Size(442, 45);
            this.dataGridViewResources.TabIndex = 5;
            // 
            // labelKingdomName
            // 
            this.labelKingdomName.AutoSize = true;
            this.labelKingdomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKingdomName.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKingdomName.Location = new System.Drawing.Point(12, 12);
            this.labelKingdomName.Name = "labelKingdomName";
            this.labelKingdomName.Size = new System.Drawing.Size(113, 24);
            this.labelKingdomName.TabIndex = 0;
            this.labelKingdomName.Text = "Twoje Królestwo ";
            // 
            // pictureBoxMint
            // 
            this.pictureBoxMint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMint.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMint.Image")));
            this.pictureBoxMint.Location = new System.Drawing.Point(203, 9);
            this.pictureBoxMint.Name = "pictureBoxMint";
            this.pictureBoxMint.Size = new System.Drawing.Size(151, 107);
            this.pictureBoxMint.TabIndex = 9;
            this.pictureBoxMint.TabStop = false;
            // 
            // pictureBoxMine
            // 
            this.pictureBoxMine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMine.Image")));
            this.pictureBoxMine.Location = new System.Drawing.Point(382, 9);
            this.pictureBoxMine.Name = "pictureBoxMine";
            this.pictureBoxMine.Size = new System.Drawing.Size(151, 106);
            this.pictureBoxMine.TabIndex = 8;
            this.pictureBoxMine.TabStop = false;
            // 
            // pictureBoxBaker
            // 
            this.pictureBoxBaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBaker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBaker.Image")));
            this.pictureBoxBaker.Location = new System.Drawing.Point(21, 10);
            this.pictureBoxBaker.Name = "pictureBoxBaker";
            this.pictureBoxBaker.Size = new System.Drawing.Size(151, 106);
            this.pictureBoxBaker.TabIndex = 7;
            this.pictureBoxBaker.TabStop = false;
            // 
            // pictureBoxSawmill
            // 
            this.pictureBoxSawmill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSawmill.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSawmill.Image")));
            this.pictureBoxSawmill.Location = new System.Drawing.Point(573, 9);
            this.pictureBoxSawmill.Name = "pictureBoxSawmill";
            this.pictureBoxSawmill.Size = new System.Drawing.Size(151, 106);
            this.pictureBoxSawmill.TabIndex = 6;
            this.pictureBoxSawmill.TabStop = false;
            // 
            // timerGoldIncrease
            // 
            this.timerGoldIncrease.Interval = 8000;
            this.timerGoldIncrease.Tick += new System.EventHandler(this.timerGoldIncrease_Tick);
            // 
            // timerWoodIncrease
            // 
            this.timerWoodIncrease.Interval = 2000;
            this.timerWoodIncrease.Tick += new System.EventHandler(this.timerWoodIncrease_Tick);
            // 
            // timerStoneIncrease
            // 
            this.timerStoneIncrease.Interval = 2000;
            this.timerStoneIncrease.Tick += new System.EventHandler(this.timerStoneIncrease_Tick);
            // 
            // timerFoodIncrease
            // 
            this.timerFoodIncrease.Interval = 3000;
            this.timerFoodIncrease.Tick += new System.EventHandler(this.timerFoodIncrease_Tick);
            // 
            // panelDownBackgroung
            // 
            this.panelDownBackgroung.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelDownBackgroung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDownBackgroung.Controls.Add(this.buttonMintUpgrade);
            this.panelDownBackgroung.Controls.Add(this.buttonMineUpgrade);
            this.panelDownBackgroung.Controls.Add(this.buttonSawmillUpgrade);
            this.panelDownBackgroung.Controls.Add(this.buttonBakerUpgrade);
            this.panelDownBackgroung.Controls.Add(this.pictureBoxSawmill);
            this.panelDownBackgroung.Controls.Add(this.pictureBoxBaker);
            this.panelDownBackgroung.Controls.Add(this.pictureBoxMine);
            this.panelDownBackgroung.Controls.Add(this.pictureBoxMint);
            this.panelDownBackgroung.Location = new System.Drawing.Point(12, 429);
            this.panelDownBackgroung.Name = "panelDownBackgroung";
            this.panelDownBackgroung.Size = new System.Drawing.Size(765, 173);
            this.panelDownBackgroung.TabIndex = 6;
            // 
            // labelSawmillLevel
            // 
            this.labelSawmillLevel.AutoSize = true;
            this.labelSawmillLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSawmillLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSawmillLevel.Location = new System.Drawing.Point(633, 596);
            this.labelSawmillLevel.Name = "labelSawmillLevel";
            this.labelSawmillLevel.Size = new System.Drawing.Size(62, 13);
            this.labelSawmillLevel.TabIndex = 14;
            this.labelSawmillLevel.Text = "Poziom: 1";
            // 
            // labelMintLevel
            // 
            this.labelMintLevel.AutoSize = true;
            this.labelMintLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMintLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMintLevel.Location = new System.Drawing.Point(262, 596);
            this.labelMintLevel.Name = "labelMintLevel";
            this.labelMintLevel.Size = new System.Drawing.Size(62, 13);
            this.labelMintLevel.TabIndex = 13;
            this.labelMintLevel.Text = "Poziom: 1";
            // 
            // buttonMintUpgrade
            // 
            this.buttonMintUpgrade.Location = new System.Drawing.Point(235, 122);
            this.buttonMintUpgrade.Name = "buttonMintUpgrade";
            this.buttonMintUpgrade.Size = new System.Drawing.Size(89, 35);
            this.buttonMintUpgrade.TabIndex = 6;
            this.buttonMintUpgrade.Text = "Ulepsz Mennice";
            this.buttonMintUpgrade.UseVisualStyleBackColor = true;
            this.buttonMintUpgrade.Click += new System.EventHandler(this.buttonMintUpgrade_Click);
            // 
            // labelMineLevel
            // 
            this.labelMineLevel.AutoSize = true;
            this.labelMineLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMineLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMineLevel.Location = new System.Drawing.Point(446, 596);
            this.labelMineLevel.Name = "labelMineLevel";
            this.labelMineLevel.Size = new System.Drawing.Size(62, 13);
            this.labelMineLevel.TabIndex = 12;
            this.labelMineLevel.Text = "Poziom: 1";
            // 
            // labelBakerLevel
            // 
            this.labelBakerLevel.AutoSize = true;
            this.labelBakerLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelBakerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBakerLevel.Location = new System.Drawing.Point(77, 596);
            this.labelBakerLevel.Name = "labelBakerLevel";
            this.labelBakerLevel.Size = new System.Drawing.Size(62, 13);
            this.labelBakerLevel.TabIndex = 11;
            this.labelBakerLevel.Text = "Poziom: 1";
            // 
            // buttonMineUpgrade
            // 
            this.buttonMineUpgrade.Location = new System.Drawing.Point(419, 123);
            this.buttonMineUpgrade.Name = "buttonMineUpgrade";
            this.buttonMineUpgrade.Size = new System.Drawing.Size(89, 35);
            this.buttonMineUpgrade.TabIndex = 6;
            this.buttonMineUpgrade.Text = "Ulepsz Kopalnie";
            this.buttonMineUpgrade.UseVisualStyleBackColor = true;
            this.buttonMineUpgrade.Click += new System.EventHandler(this.buttonMineUpgrade_Click);
            // 
            // buttonSawmillUpgrade
            // 
            this.buttonSawmillUpgrade.Location = new System.Drawing.Point(605, 123);
            this.buttonSawmillUpgrade.Name = "buttonSawmillUpgrade";
            this.buttonSawmillUpgrade.Size = new System.Drawing.Size(89, 35);
            this.buttonSawmillUpgrade.TabIndex = 10;
            this.buttonSawmillUpgrade.Text = "Ulepsz \r\nTartak";
            this.buttonSawmillUpgrade.UseVisualStyleBackColor = true;
            this.buttonSawmillUpgrade.Click += new System.EventHandler(this.buttonSawmillUpgrade_Click);
            // 
            // buttonBakerUpgrade
            // 
            this.buttonBakerUpgrade.Location = new System.Drawing.Point(52, 123);
            this.buttonBakerUpgrade.Name = "buttonBakerUpgrade";
            this.buttonBakerUpgrade.Size = new System.Drawing.Size(89, 35);
            this.buttonBakerUpgrade.TabIndex = 6;
            this.buttonBakerUpgrade.Text = "Ulepsz Piekarnie";
            this.buttonBakerUpgrade.UseVisualStyleBackColor = true;
            this.buttonBakerUpgrade.Click += new System.EventHandler(this.buttonBakerUpgrade_Click);
            // 
            // labelBakerUpgradeCost
            // 
            this.labelBakerUpgradeCost.AutoSize = true;
            this.labelBakerUpgradeCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelBakerUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBakerUpgradeCost.Location = new System.Drawing.Point(62, 620);
            this.labelBakerUpgradeCost.Name = "labelBakerUpgradeCost";
            this.labelBakerUpgradeCost.Size = new System.Drawing.Size(93, 13);
            this.labelBakerUpgradeCost.TabIndex = 15;
            this.labelBakerUpgradeCost.Text = "Koszt: 30 złota";
            // 
            // labelMintUpgradeCost
            // 
            this.labelMintUpgradeCost.AutoSize = true;
            this.labelMintUpgradeCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMintUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMintUpgradeCost.Location = new System.Drawing.Point(244, 620);
            this.labelMintUpgradeCost.Name = "labelMintUpgradeCost";
            this.labelMintUpgradeCost.Size = new System.Drawing.Size(93, 13);
            this.labelMintUpgradeCost.TabIndex = 16;
            this.labelMintUpgradeCost.Text = "Koszt: 30 złota";
            // 
            // labelMineUpgradeCost
            // 
            this.labelMineUpgradeCost.AutoSize = true;
            this.labelMineUpgradeCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelMineUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMineUpgradeCost.Location = new System.Drawing.Point(429, 620);
            this.labelMineUpgradeCost.Name = "labelMineUpgradeCost";
            this.labelMineUpgradeCost.Size = new System.Drawing.Size(93, 13);
            this.labelMineUpgradeCost.TabIndex = 17;
            this.labelMineUpgradeCost.Text = "Koszt: 30 złota";
            // 
            // labelSawmillUpgradeCost
            // 
            this.labelSawmillUpgradeCost.AutoSize = true;
            this.labelSawmillUpgradeCost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSawmillUpgradeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSawmillUpgradeCost.Location = new System.Drawing.Point(614, 620);
            this.labelSawmillUpgradeCost.Name = "labelSawmillUpgradeCost";
            this.labelSawmillUpgradeCost.Size = new System.Drawing.Size(93, 13);
            this.labelSawmillUpgradeCost.TabIndex = 18;
            this.labelSawmillUpgradeCost.Text = "Koszt: 30 złota";
            // 
            // buttonFire
            // 
            this.buttonFire.BackColor = System.Drawing.Color.Red;
            this.buttonFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFire.Location = new System.Drawing.Point(12, 361);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(113, 30);
            this.buttonFire.TabIndex = 6;
            this.buttonFire.Text = "Wywołaj pożar";
            this.buttonFire.UseVisualStyleBackColor = false;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // FormHomework1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(789, 643);
            this.Controls.Add(this.labelSawmillLevel);
            this.Controls.Add(this.labelSawmillUpgradeCost);
            this.Controls.Add(this.labelMintLevel);
            this.Controls.Add(this.labelMineLevel);
            this.Controls.Add(this.labelMineUpgradeCost);
            this.Controls.Add(this.labelMintUpgradeCost);
            this.Controls.Add(this.labelBakerUpgradeCost);
            this.Controls.Add(this.labelBakerLevel);
            this.Controls.Add(this.panelBackgound);
            this.Controls.Add(this.panelDownBackgroung);
            this.Name = "FormHomework1";
            this.Text = "Zadanie domowe 1";
            this.panelBackgound.ResumeLayout(false);
            this.panelBackgound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSawmill)).EndInit();
            this.panelDownBackgroung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBackgound;
        private System.Windows.Forms.DataGridView dataGridViewResources;
        private System.Windows.Forms.Timer timerGoldIncrease;
        private System.Windows.Forms.Timer timerWoodIncrease;
        private System.Windows.Forms.Timer timerStoneIncrease;
        private System.Windows.Forms.Timer timerFoodIncrease;
        private System.Windows.Forms.PictureBox pictureBoxMint;
        private System.Windows.Forms.PictureBox pictureBoxMine;
        private System.Windows.Forms.PictureBox pictureBoxBaker;
        private System.Windows.Forms.PictureBox pictureBoxSawmill;
        private System.Windows.Forms.Panel panelDownBackgroung;
        private System.Windows.Forms.Button buttonMineUpgrade;
        private System.Windows.Forms.Button buttonSawmillUpgrade;
        private System.Windows.Forms.Button buttonMintUpgrade;
        private System.Windows.Forms.Button buttonBakerUpgrade;
        private System.Windows.Forms.Label labelSawmillLevel;
        private System.Windows.Forms.Label labelMintLevel;
        private System.Windows.Forms.Label labelMineLevel;
        private System.Windows.Forms.Label labelBakerLevel;
        public System.Windows.Forms.Label labelKingdomName;
        private System.Windows.Forms.Label labelBakerUpgradeCost;
        private System.Windows.Forms.Label labelMintUpgradeCost;
        private System.Windows.Forms.Label labelMineUpgradeCost;
        private System.Windows.Forms.Label labelSawmillUpgradeCost;
        private System.Windows.Forms.Button buttonFire;
    }
}

