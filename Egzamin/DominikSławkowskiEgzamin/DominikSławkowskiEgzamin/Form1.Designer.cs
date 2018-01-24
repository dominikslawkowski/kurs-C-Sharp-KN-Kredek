namespace DominikSławkowskiEgzamin
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
            this.textBoxPolicz = new System.Windows.Forms.TextBox();
            this.buttonPolicz = new System.Windows.Forms.Button();
            this.buttonLewo = new System.Windows.Forms.Button();
            this.buttonPrawo = new System.Windows.Forms.Button();
            this.buttonPasekPostepu = new System.Windows.Forms.Button();
            this.progressBarPasekPostepu = new System.Windows.Forms.ProgressBar();
            this.timerPasekPostepu = new System.Windows.Forms.Timer(this.components);
            this.buttonPracownicy = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonProdukty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPolicz
            // 
            this.textBoxPolicz.Location = new System.Drawing.Point(54, 37);
            this.textBoxPolicz.Name = "textBoxPolicz";
            this.textBoxPolicz.Size = new System.Drawing.Size(117, 22);
            this.textBoxPolicz.TabIndex = 0;
            // 
            // buttonPolicz
            // 
            this.buttonPolicz.Location = new System.Drawing.Point(54, 90);
            this.buttonPolicz.Name = "buttonPolicz";
            this.buttonPolicz.Size = new System.Drawing.Size(117, 30);
            this.buttonPolicz.TabIndex = 1;
            this.buttonPolicz.Text = "A.1 Policz";
            this.buttonPolicz.UseVisualStyleBackColor = true;
            this.buttonPolicz.Click += new System.EventHandler(this.buttonPolicz_Click);
            // 
            // buttonLewo
            // 
            this.buttonLewo.Location = new System.Drawing.Point(246, 90);
            this.buttonLewo.Name = "buttonLewo";
            this.buttonLewo.Size = new System.Drawing.Size(75, 30);
            this.buttonLewo.TabIndex = 2;
            this.buttonLewo.Text = "<--";
            this.buttonLewo.UseVisualStyleBackColor = true;
            this.buttonLewo.Click += new System.EventHandler(this.buttonLewo_Click);
            // 
            // buttonPrawo
            // 
            this.buttonPrawo.Location = new System.Drawing.Point(347, 90);
            this.buttonPrawo.Name = "buttonPrawo";
            this.buttonPrawo.Size = new System.Drawing.Size(75, 30);
            this.buttonPrawo.TabIndex = 3;
            this.buttonPrawo.Text = "-->";
            this.buttonPrawo.UseVisualStyleBackColor = true;
            this.buttonPrawo.Click += new System.EventHandler(this.buttonPrawo_Click);
            // 
            // buttonPasekPostepu
            // 
            this.buttonPasekPostepu.Location = new System.Drawing.Point(491, 90);
            this.buttonPasekPostepu.Name = "buttonPasekPostepu";
            this.buttonPasekPostepu.Size = new System.Drawing.Size(117, 30);
            this.buttonPasekPostepu.TabIndex = 4;
            this.buttonPasekPostepu.Text = "A.3 Pasek postepu";
            this.buttonPasekPostepu.UseVisualStyleBackColor = true;
            this.buttonPasekPostepu.Click += new System.EventHandler(this.buttonPasekPostepu_Click);
            // 
            // progressBarPasekPostepu
            // 
            this.progressBarPasekPostepu.Location = new System.Drawing.Point(491, 37);
            this.progressBarPasekPostepu.Name = "progressBarPasekPostepu";
            this.progressBarPasekPostepu.Size = new System.Drawing.Size(117, 23);
            this.progressBarPasekPostepu.TabIndex = 5;
            // 
            // timerPasekPostepu
            // 
            this.timerPasekPostepu.Interval = 500;
            this.timerPasekPostepu.Tick += new System.EventHandler(this.timerPasekPostepu_Tick);
            // 
            // buttonPracownicy
            // 
            this.buttonPracownicy.Location = new System.Drawing.Point(54, 364);
            this.buttonPracownicy.Name = "buttonPracownicy";
            this.buttonPracownicy.Size = new System.Drawing.Size(152, 30);
            this.buttonPracownicy.TabIndex = 6;
            this.buttonPracownicy.Text = "A.4 Pracownicy";
            this.buttonPracownicy.UseVisualStyleBackColor = true;
            this.buttonPracownicy.Click += new System.EventHandler(this.buttonPracownicy_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(54, 178);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(418, 150);
            this.dataGridViewMain.TabIndex = 7;
            // 
            // buttonProdukty
            // 
            this.buttonProdukty.Location = new System.Drawing.Point(234, 364);
            this.buttonProdukty.Name = "buttonProdukty";
            this.buttonProdukty.Size = new System.Drawing.Size(188, 30);
            this.buttonProdukty.TabIndex = 8;
            this.buttonProdukty.Text = "A.6 Produkty";
            this.buttonProdukty.UseVisualStyleBackColor = true;
            this.buttonProdukty.Click += new System.EventHandler(this.buttonProdukty_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.buttonProdukty);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.buttonPracownicy);
            this.Controls.Add(this.progressBarPasekPostepu);
            this.Controls.Add(this.buttonPasekPostepu);
            this.Controls.Add(this.buttonPrawo);
            this.Controls.Add(this.buttonLewo);
            this.Controls.Add(this.buttonPolicz);
            this.Controls.Add(this.textBoxPolicz);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPolicz;
        private System.Windows.Forms.Button buttonPolicz;
        private System.Windows.Forms.Button buttonLewo;
        private System.Windows.Forms.Button buttonPrawo;
        private System.Windows.Forms.Button buttonPasekPostepu;
        private System.Windows.Forms.ProgressBar progressBarPasekPostepu;
        private System.Windows.Forms.Timer timerPasekPostepu;
        private System.Windows.Forms.Button buttonPracownicy;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonProdukty;
    }
}

