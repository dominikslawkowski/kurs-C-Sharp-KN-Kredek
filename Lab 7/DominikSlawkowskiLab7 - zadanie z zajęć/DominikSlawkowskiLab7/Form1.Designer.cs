namespace DominikSlawkowskiLab7
{
    partial class FormMain
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelObjectName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonGrafika = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.timerLine = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMonitor = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(44, 128);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(135, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Wyślij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(44, 90);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(135, 23);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Pobierz";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.Download_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(38, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(247, 33);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Dominik Sławkowski";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(41, 176);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(41, 211);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(102, 173);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(102, 208);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 6;
            // 
            // labelObjectName
            // 
            this.labelObjectName.AutoSize = true;
            this.labelObjectName.Location = new System.Drawing.Point(41, 249);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(43, 13);
            this.labelObjectName.TabIndex = 7;
            this.labelObjectName.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 246);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(315, 74);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTable.TabIndex = 9;
            // 
            // buttonGrafika
            // 
            this.buttonGrafika.Location = new System.Drawing.Point(44, 332);
            this.buttonGrafika.Name = "buttonGrafika";
            this.buttonGrafika.Size = new System.Drawing.Size(135, 23);
            this.buttonGrafika.TabIndex = 10;
            this.buttonGrafika.Text = "Grafika";
            this.buttonGrafika.UseVisualStyleBackColor = true;
            this.buttonGrafika.Click += new System.EventHandler(this.buttonFigure_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(613, 408);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(86, 23);
            this.buttonUp.TabIndex = 11;
            this.buttonUp.Text = "Góra";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(613, 466);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(86, 23);
            this.buttonDown.TabIndex = 12;
            this.buttonDown.Text = "Dół";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(535, 437);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(86, 23);
            this.buttonLeft.TabIndex = 13;
            this.buttonLeft.Text = "Lewo";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(693, 437);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(86, 23);
            this.buttonRight.TabIndex = 14;
            this.buttonRight.Text = "Prawo";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(44, 361);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(135, 23);
            this.buttonChangeColor.TabIndex = 15;
            this.buttonChangeColor.Text = "Zmien kolor";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // timerAuto
            // 
            this.timerAuto.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(44, 390);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(135, 23);
            this.buttonAuto.TabIndex = 16;
            this.buttonAuto.Text = "Automatycznie";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(44, 437);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(135, 23);
            this.buttonLine.TabIndex = 17;
            this.buttonLine.Text = "Linia";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // timerLine
            // 
            this.timerLine.Tick += new System.EventHandler(this.timerAuto_Tick_1);
            // 
            // notifyIconMonitor
            // 
            this.notifyIconMonitor.Text = "notifyIcon1";
            this.notifyIconMonitor.Visible = true;
            this.notifyIconMonitor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMonitor_MouseDoubleClick);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(233, 437);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(135, 23);
            this.buttonBackground.TabIndex = 18;
            this.buttonBackground.Text = "Praca w tle";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(644, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 23);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 550);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonGrafika);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelObjectName);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonSend);
            this.Name = "FormMain";
            this.Text = "Projekt";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelObjectName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonGrafika;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Timer timerAuto;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Timer timerLine;
        private System.Windows.Forms.NotifyIcon notifyIconMonitor;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonStart;
    }
}

