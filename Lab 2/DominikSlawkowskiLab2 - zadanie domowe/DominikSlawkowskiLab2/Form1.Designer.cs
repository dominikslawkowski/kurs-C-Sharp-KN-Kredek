namespace DominikSlawkowskiLab2
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
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelEnemy = new System.Windows.Forms.Panel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.labelLayout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.buttonStrongAttack = new System.Windows.Forms.Button();
            this.progressBarEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.labelPlayerHealth = new System.Windows.Forms.Label();
            this.progressBarPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.buttonRest = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.timerEnemyAttack = new System.Windows.Forms.Timer(this.components);
            this.timerCheckWhoIsDead = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPlayer.BackgroundImage")));
            this.panelPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayer.Location = new System.Drawing.Point(50, 62);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(110, 182);
            this.panelPlayer.TabIndex = 0;
            this.panelPlayer.Visible = false;
            // 
            // panelEnemy
            // 
            this.panelEnemy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnemy.BackgroundImage")));
            this.panelEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEnemy.Location = new System.Drawing.Point(288, 62);
            this.panelEnemy.Name = "panelEnemy";
            this.panelEnemy.Size = new System.Drawing.Size(110, 182);
            this.panelEnemy.TabIndex = 1;
            this.panelEnemy.Visible = false;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(47, 25);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(35, 13);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Gracz";
            this.labelPlayer.Visible = false;
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Location = new System.Drawing.Point(285, 25);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(58, 13);
            this.labelEnemy.TabIndex = 3;
            this.labelEnemy.Text = "Przeciwnik";
            this.labelEnemy.Visible = false;
            // 
            // labelLayout
            // 
            this.labelLayout.AutoSize = true;
            this.labelLayout.Location = new System.Drawing.Point(212, 139);
            this.labelLayout.Name = "labelLayout";
            this.labelLayout.Size = new System.Drawing.Size(24, 13);
            this.labelLayout.TabIndex = 4;
            this.labelLayout.Text = "VS.";
            this.labelLayout.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.labelInfoTitle);
            this.panel1.Controls.Add(this.buttonStrongAttack);
            this.panel1.Controls.Add(this.progressBarEnemyHealth);
            this.panel1.Controls.Add(this.labelEnemyHealth);
            this.panel1.Controls.Add(this.labelPlayerHealth);
            this.panel1.Controls.Add(this.progressBarPlayerHealth);
            this.panel1.Controls.Add(this.buttonRest);
            this.panel1.Controls.Add(this.buttonAttack);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.comboBoxClass);
            this.panel1.Controls.Add(this.labelClass);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelLayout);
            this.panel1.Controls.Add(this.labelEnemy);
            this.panel1.Controls.Add(this.labelPlayer);
            this.panel1.Controls.Add(this.panelEnemy);
            this.panel1.Controls.Add(this.panelPlayer);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 426);
            this.panel1.TabIndex = 5;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelInfo.Location = new System.Drawing.Point(272, 360);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(16, 13);
            this.labelInfo.TabIndex = 19;
            this.labelInfo.Text = "---";
            this.labelInfo.Visible = false;
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Location = new System.Drawing.Point(290, 333);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(62, 13);
            this.labelInfoTitle.TabIndex = 18;
            this.labelInfoTitle.Text = "Informacja: ";
            this.labelInfoTitle.Visible = false;
            // 
            // buttonStrongAttack
            // 
            this.buttonStrongAttack.Location = new System.Drawing.Point(50, 355);
            this.buttonStrongAttack.Name = "buttonStrongAttack";
            this.buttonStrongAttack.Size = new System.Drawing.Size(105, 23);
            this.buttonStrongAttack.TabIndex = 17;
            this.buttonStrongAttack.Text = "Atakuj z całej sily";
            this.buttonStrongAttack.UseVisualStyleBackColor = true;
            this.buttonStrongAttack.Visible = false;
            this.buttonStrongAttack.Click += new System.EventHandler(this.buttonStrongAttack_Click);
            // 
            // progressBarEnemyHealth
            // 
            this.progressBarEnemyHealth.Location = new System.Drawing.Point(293, 286);
            this.progressBarEnemyHealth.MarqueeAnimationSpeed = 0;
            this.progressBarEnemyHealth.Name = "progressBarEnemyHealth";
            this.progressBarEnemyHealth.Size = new System.Drawing.Size(100, 16);
            this.progressBarEnemyHealth.Step = 0;
            this.progressBarEnemyHealth.TabIndex = 16;
            this.progressBarEnemyHealth.Value = 100;
            this.progressBarEnemyHealth.Visible = false;
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.Location = new System.Drawing.Point(324, 261);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(45, 13);
            this.labelEnemyHealth.TabIndex = 15;
            this.labelEnemyHealth.Text = "Zdrowie";
            this.labelEnemyHealth.Visible = false;
            // 
            // labelPlayerHealth
            // 
            this.labelPlayerHealth.AutoSize = true;
            this.labelPlayerHealth.Location = new System.Drawing.Point(82, 261);
            this.labelPlayerHealth.Name = "labelPlayerHealth";
            this.labelPlayerHealth.Size = new System.Drawing.Size(45, 13);
            this.labelPlayerHealth.TabIndex = 14;
            this.labelPlayerHealth.Text = "Zdrowie";
            this.labelPlayerHealth.Visible = false;
            // 
            // progressBarPlayerHealth
            // 
            this.progressBarPlayerHealth.Location = new System.Drawing.Point(55, 286);
            this.progressBarPlayerHealth.MarqueeAnimationSpeed = 0;
            this.progressBarPlayerHealth.Name = "progressBarPlayerHealth";
            this.progressBarPlayerHealth.Size = new System.Drawing.Size(100, 16);
            this.progressBarPlayerHealth.Step = 0;
            this.progressBarPlayerHealth.TabIndex = 12;
            this.progressBarPlayerHealth.Value = 100;
            this.progressBarPlayerHealth.Visible = false;
            // 
            // buttonRest
            // 
            this.buttonRest.Location = new System.Drawing.Point(66, 386);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(75, 23);
            this.buttonRest.TabIndex = 11;
            this.buttonRest.Text = "Odpocznij";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Visible = false;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(66, 323);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(75, 23);
            this.buttonAttack.TabIndex = 10;
            this.buttonAttack.Text = "Atakuj";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Visible = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(199, 219);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Rozpocznij";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Rycerz",
            "Mag"});
            this.comboBoxClass.Location = new System.Drawing.Point(199, 164);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 8;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(116, 164);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(39, 13);
            this.labelClass.TabIndex = 7;
            this.labelClass.Text = "Klasa: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(199, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(116, 119);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Imię bohatera: ";
            // 
            // timerEnemyAttack
            // 
            this.timerEnemyAttack.Interval = 2000;
            this.timerEnemyAttack.Tick += new System.EventHandler(this.timerEnemyAttack_Tick);
            // 
            // timerCheckWhoIsDead
            // 
            this.timerCheckWhoIsDead.Tick += new System.EventHandler(this.timerCheckWhoIsDead_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(470, 446);
            this.Controls.Add(this.panel1);
            this.Name = "FormGame";
            this.Text = "Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelEnemy;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Label labelLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEnemyHealth;
        private System.Windows.Forms.Label labelPlayerHealth;
        private System.Windows.Forms.Button buttonRest;
        private System.Windows.Forms.Button buttonAttack;
        public System.Windows.Forms.ProgressBar progressBarPlayerHealth;
        public System.Windows.Forms.ProgressBar progressBarEnemyHealth;
        private System.Windows.Forms.Button buttonStrongAttack;
        private System.Windows.Forms.Label labelInfoTitle;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.Timer timerEnemyAttack;
        public System.Windows.Forms.Timer timerCheckWhoIsDead;
    }
}

