namespace DominikSlawkowskiLab2
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelHorseName = new System.Windows.Forms.Label();
            this.labelNumberOfLegs = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxHorseName = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfLegs = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxCorner = new System.Windows.Forms.CheckBox();
            this.buttonAddHorse = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAddUnicorn = new System.Windows.Forms.Button();
            this.buttonDeleteUnicorn = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.labelMedian = new System.Windows.Forms.Label();
            this.dataGridViewHorse = new System.Windows.Forms.DataGridView();
            this.textBoxHorses = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(-1, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(458, 55);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Dominik Sławkowski";
            // 
            // labelHorseName
            // 
            this.labelHorseName.AutoSize = true;
            this.labelHorseName.Location = new System.Drawing.Point(12, 104);
            this.labelHorseName.Name = "labelHorseName";
            this.labelHorseName.Size = new System.Drawing.Size(83, 20);
            this.labelHorseName.TabIndex = 1;
            this.labelHorseName.Text = "imię konia:";
            // 
            // labelNumberOfLegs
            // 
            this.labelNumberOfLegs.AutoSize = true;
            this.labelNumberOfLegs.Location = new System.Drawing.Point(12, 150);
            this.labelNumberOfLegs.Name = "labelNumberOfLegs";
            this.labelNumberOfLegs.Size = new System.Drawing.Size(84, 20);
            this.labelNumberOfLegs.TabIndex = 2;
            this.labelNumberOfLegs.Text = "liczba nóg:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 203);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(108, 20);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "kolor cekinów:";
            // 
            // textBoxHorseName
            // 
            this.textBoxHorseName.Location = new System.Drawing.Point(126, 101);
            this.textBoxHorseName.Name = "textBoxHorseName";
            this.textBoxHorseName.Size = new System.Drawing.Size(100, 26);
            this.textBoxHorseName.TabIndex = 4;
            // 
            // textBoxNumberOfLegs
            // 
            this.textBoxNumberOfLegs.Location = new System.Drawing.Point(126, 150);
            this.textBoxNumberOfLegs.Name = "textBoxNumberOfLegs";
            this.textBoxNumberOfLegs.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfLegs.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // checkBoxCorner
            // 
            this.checkBoxCorner.AutoSize = true;
            this.checkBoxCorner.Location = new System.Drawing.Point(12, 273);
            this.checkBoxCorner.Name = "checkBoxCorner";
            this.checkBoxCorner.Size = new System.Drawing.Size(58, 24);
            this.checkBoxCorner.TabIndex = 7;
            this.checkBoxCorner.Text = "róg";
            this.checkBoxCorner.UseVisualStyleBackColor = true;
            // 
            // buttonAddHorse
            // 
            this.buttonAddHorse.Location = new System.Drawing.Point(16, 355);
            this.buttonAddHorse.Name = "buttonAddHorse";
            this.buttonAddHorse.Size = new System.Drawing.Size(104, 55);
            this.buttonAddHorse.TabIndex = 8;
            this.buttonAddHorse.Text = "dodaj konia";
            this.buttonAddHorse.UseVisualStyleBackColor = true;
            this.buttonAddHorse.Click += new System.EventHandler(this.buttonAddHorse_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(141, 355);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 55);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "pokaż";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonAddUnicorn
            // 
            this.buttonAddUnicorn.Location = new System.Drawing.Point(535, 355);
            this.buttonAddUnicorn.Name = "buttonAddUnicorn";
            this.buttonAddUnicorn.Size = new System.Drawing.Size(106, 55);
            this.buttonAddUnicorn.TabIndex = 10;
            this.buttonAddUnicorn.Text = "dodaj jednorozca";
            this.buttonAddUnicorn.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUnicorn
            // 
            this.buttonDeleteUnicorn.Location = new System.Drawing.Point(674, 355);
            this.buttonDeleteUnicorn.Name = "buttonDeleteUnicorn";
            this.buttonDeleteUnicorn.Size = new System.Drawing.Size(94, 55);
            this.buttonDeleteUnicorn.TabIndex = 11;
            this.buttonDeleteUnicorn.Text = "usuń";
            this.buttonDeleteUnicorn.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(800, 355);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(93, 55);
            this.button.TabIndex = 12;
            this.button.Text = "button5";
            this.button.UseVisualStyleBackColor = true;
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Location = new System.Drawing.Point(531, 453);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(127, 20);
            this.labelMedian.TabIndex = 13;
            this.labelMedian.Text = "średnia ilość nóg";
            // 
            // dataGridViewHorse
            // 
            this.dataGridViewHorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorse.Location = new System.Drawing.Point(535, 79);
            this.dataGridViewHorse.Name = "dataGridViewHorse";
            this.dataGridViewHorse.RowTemplate.Height = 28;
            this.dataGridViewHorse.Size = new System.Drawing.Size(399, 218);
            this.dataGridViewHorse.TabIndex = 14;
            // 
            // textBoxHorses
            // 
            this.textBoxHorses.Location = new System.Drawing.Point(254, 79);
            this.textBoxHorses.Multiline = true;
            this.textBoxHorses.Name = "textBoxHorses";
            this.textBoxHorses.Size = new System.Drawing.Size(236, 260);
            this.textBoxHorses.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 615);
            this.Controls.Add(this.textBoxHorses);
            this.Controls.Add(this.dataGridViewHorse);
            this.Controls.Add(this.labelMedian);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonDeleteUnicorn);
            this.Controls.Add(this.buttonAddUnicorn);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAddHorse);
            this.Controls.Add(this.checkBoxCorner);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxNumberOfLegs);
            this.Controls.Add(this.textBoxHorseName);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelNumberOfLegs);
            this.Controls.Add(this.labelHorseName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHorseName;
        private System.Windows.Forms.Label labelNumberOfLegs;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxHorseName;
        private System.Windows.Forms.TextBox textBoxNumberOfLegs;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxCorner;
        private System.Windows.Forms.Button buttonAddHorse;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAddUnicorn;
        private System.Windows.Forms.Button buttonDeleteUnicorn;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.DataGridView dataGridViewHorse;
        private System.Windows.Forms.TextBox textBoxHorses;
    }
}

