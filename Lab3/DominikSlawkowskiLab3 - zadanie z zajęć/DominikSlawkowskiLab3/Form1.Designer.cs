namespace DominikSlawkowskiLab3
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
            this.labelMyName = new System.Windows.Forms.Label();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.buttonFilms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMyName
            // 
            this.labelMyName.AutoSize = true;
            this.labelMyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMyName.Location = new System.Drawing.Point(13, 13);
            this.labelMyName.Name = "labelMyName";
            this.labelMyName.Size = new System.Drawing.Size(224, 25);
            this.labelMyName.TabIndex = 0;
            this.labelMyName.Text = "Dominik Sławkowski";
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.Location = new System.Drawing.Point(18, 52);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.Size = new System.Drawing.Size(538, 250);
            this.dataGridViewFilm.TabIndex = 1;
            // 
            // buttonFilms
            // 
            this.buttonFilms.Location = new System.Drawing.Point(12, 336);
            this.buttonFilms.Name = "buttonFilms";
            this.buttonFilms.Size = new System.Drawing.Size(94, 31);
            this.buttonFilms.TabIndex = 2;
            this.buttonFilms.Text = "Pokaż filmy";
            this.buttonFilms.UseVisualStyleBackColor = true;
            this.buttonFilms.Click += new System.EventHandler(this.buttonFilms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 438);
            this.Controls.Add(this.buttonFilms);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.labelMyName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button buttonFilms;
    }
}

