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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.panelShip = new System.Windows.Forms.Panel();
            this.panelEnemy1 = new System.Windows.Forms.Panel();
            this.panelEnemy4 = new System.Windows.Forms.Panel();
            this.panelEnemy3 = new System.Windows.Forms.Panel();
            this.panelEnemy2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelShip
            // 
            this.panelShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShip.BackgroundImage")));
            this.panelShip.Location = new System.Drawing.Point(422, 493);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(83, 80);
            this.panelShip.TabIndex = 0;
            // 
            // panelEnemy1
            // 
            this.panelEnemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy1.BackgroundImage")));
            this.panelEnemy1.Location = new System.Drawing.Point(102, 28);
            this.panelEnemy1.Name = "panelEnemy1";
            this.panelEnemy1.Size = new System.Drawing.Size(51, 49);
            this.panelEnemy1.TabIndex = 1;
            // 
            // panelEnemy4
            // 
            this.panelEnemy4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy4.BackgroundImage")));
            this.panelEnemy4.Location = new System.Drawing.Point(757, 28);
            this.panelEnemy4.Name = "panelEnemy4";
            this.panelEnemy4.Size = new System.Drawing.Size(51, 49);
            this.panelEnemy4.TabIndex = 2;
            // 
            // panelEnemy3
            // 
            this.panelEnemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy3.BackgroundImage")));
            this.panelEnemy3.Location = new System.Drawing.Point(517, 28);
            this.panelEnemy3.Name = "panelEnemy3";
            this.panelEnemy3.Size = new System.Drawing.Size(51, 49);
            this.panelEnemy3.TabIndex = 2;
            // 
            // panelEnemy2
            // 
            this.panelEnemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy2.BackgroundImage")));
            this.panelEnemy2.Location = new System.Drawing.Point(299, 28);
            this.panelEnemy2.Name = "panelEnemy2";
            this.panelEnemy2.Size = new System.Drawing.Size(51, 49);
            this.panelEnemy2.TabIndex = 2;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(931, 585);
            this.Controls.Add(this.panelEnemy4);
            this.Controls.Add(this.panelEnemy3);
            this.Controls.Add(this.panelEnemy2);
            this.Controls.Add(this.panelEnemy1);
            this.Controls.Add(this.panelShip);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPACE INVADERS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.Panel panelEnemy1;
        private System.Windows.Forms.Panel panelEnemy4;
        private System.Windows.Forms.Panel panelEnemy3;
        private System.Windows.Forms.Panel panelEnemy2;
    }
}