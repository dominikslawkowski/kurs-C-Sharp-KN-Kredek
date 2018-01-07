namespace DominikSlawkowskiLab7
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.panelShip = new System.Windows.Forms.Panel();
            this.panelEnemy1 = new System.Windows.Forms.Panel();
            this.panelEnemy4 = new System.Windows.Forms.Panel();
            this.panelEnemy3 = new System.Windows.Forms.Panel();
            this.panelEnemy2 = new System.Windows.Forms.Panel();
            this.timerLasers = new System.Windows.Forms.Timer(this.components);
            this.timerAliens = new System.Windows.Forms.Timer(this.components);
            this.timerRandomisation = new System.Windows.Forms.Timer(this.components);
            this.timerAlienLasers = new System.Windows.Forms.Timer(this.components);
            this.timerAlienShoot = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelEndBackground = new System.Windows.Forms.Panel();
            this.panelEndBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShip
            // 
            this.panelShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShip.BackgroundImage")));
            this.panelShip.Location = new System.Drawing.Point(563, 607);
            this.panelShip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(111, 98);
            this.panelShip.TabIndex = 0;
            // 
            // panelEnemy1
            // 
            this.panelEnemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy1.BackgroundImage")));
            this.panelEnemy1.Location = new System.Drawing.Point(136, 34);
            this.panelEnemy1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEnemy1.Name = "panelEnemy1";
            this.panelEnemy1.Size = new System.Drawing.Size(68, 60);
            this.panelEnemy1.TabIndex = 1;
            // 
            // panelEnemy4
            // 
            this.panelEnemy4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy4.BackgroundImage")));
            this.panelEnemy4.Location = new System.Drawing.Point(1009, 34);
            this.panelEnemy4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEnemy4.Name = "panelEnemy4";
            this.panelEnemy4.Size = new System.Drawing.Size(68, 60);
            this.panelEnemy4.TabIndex = 2;
            // 
            // panelEnemy3
            // 
            this.panelEnemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy3.BackgroundImage")));
            this.panelEnemy3.Location = new System.Drawing.Point(689, 34);
            this.panelEnemy3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEnemy3.Name = "panelEnemy3";
            this.panelEnemy3.Size = new System.Drawing.Size(68, 60);
            this.panelEnemy3.TabIndex = 2;
            // 
            // panelEnemy2
            // 
            this.panelEnemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy2.BackgroundImage")));
            this.panelEnemy2.Location = new System.Drawing.Point(399, 34);
            this.panelEnemy2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEnemy2.Name = "panelEnemy2";
            this.panelEnemy2.Size = new System.Drawing.Size(68, 60);
            this.panelEnemy2.TabIndex = 2;
            // 
            // timerLasers
            // 
            this.timerLasers.Interval = 1;
            this.timerLasers.Tick += new System.EventHandler(this.timerLasers_Tick);
            // 
            // timerAliens
            // 
            this.timerAliens.Tick += new System.EventHandler(this.timerAliens_Tick);
            // 
            // timerRandomisation
            // 
            this.timerRandomisation.Tick += new System.EventHandler(this.timerRandomisation_Tick);
            // 
            // timerAlienLasers
            // 
            this.timerAlienLasers.Interval = 1;
            this.timerAlienLasers.Tick += new System.EventHandler(this.timerAlienLasers_Tick);
            // 
            // timerAlienShoot
            // 
            this.timerAlienShoot.Interval = 2000;
            this.timerAlienShoot.Tick += new System.EventHandler(this.timerAlienShoot_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(229, 12);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(103, 52);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "End";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(129, 69);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(216, 39);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Your Score: ";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Aqua;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(75, 129);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(188, 41);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Play Again";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Aqua;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMenu.Location = new System.Drawing.Point(319, 129);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(191, 41);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelEndBackground
            // 
            this.panelEndBackground.BackColor = System.Drawing.Color.DimGray;
            this.panelEndBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndBackground.Controls.Add(this.buttonMenu);
            this.panelEndBackground.Controls.Add(this.buttonStart);
            this.panelEndBackground.Controls.Add(this.labelScore);
            this.panelEndBackground.Controls.Add(this.labelTitle);
            this.panelEndBackground.Location = new System.Drawing.Point(325, 226);
            this.panelEndBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEndBackground.Name = "panelEndBackground";
            this.panelEndBackground.Size = new System.Drawing.Size(581, 204);
            this.panelEndBackground.TabIndex = 3;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1241, 720);
            this.Controls.Add(this.panelEndBackground);
            this.Controls.Add(this.panelEnemy4);
            this.Controls.Add(this.panelEnemy3);
            this.Controls.Add(this.panelEnemy2);
            this.Controls.Add(this.panelEnemy1);
            this.Controls.Add(this.panelShip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPACE INVADERS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            this.panelEndBackground.ResumeLayout(false);
            this.panelEndBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.Panel panelEnemy1;
        private System.Windows.Forms.Panel panelEnemy4;
        private System.Windows.Forms.Panel panelEnemy3;
        private System.Windows.Forms.Panel panelEnemy2;
        private System.Windows.Forms.Timer timerLasers;
        private System.Windows.Forms.Timer timerAliens;
        private System.Windows.Forms.Timer timerRandomisation;
        private System.Windows.Forms.Timer timerAlienLasers;
        private System.Windows.Forms.Timer timerAlienShoot;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelEndBackground;
    }
}