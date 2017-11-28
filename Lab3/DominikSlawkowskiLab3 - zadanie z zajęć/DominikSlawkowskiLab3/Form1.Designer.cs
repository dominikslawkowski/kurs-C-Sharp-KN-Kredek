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
            this.labelActorBirthDate = new System.Windows.Forms.Label();
            this.labelActorSurname = new System.Windows.Forms.Label();
            this.dateTimePickerActorBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxActorSurname = new System.Windows.Forms.TextBox();
            this.textBoxActorName = new System.Windows.Forms.TextBox();
            this.buttonSurnameLike = new System.Windows.Forms.Button();
            this.buttonActors = new System.Windows.Forms.Button();
            this.buttonActorInsert = new System.Windows.Forms.Button();
            this.labelActorName = new System.Windows.Forms.Label();
            this.panelActorsBackground = new System.Windows.Forms.Panel();
            this.panelFilmBackground = new System.Windows.Forms.Panel();
            this.labelFilmDuration = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.textBoxFilmDuration = new System.Windows.Forms.TextBox();
            this.textBoxFilmName = new System.Windows.Forms.TextBox();
            this.buttonNameLike = new System.Windows.Forms.Button();
            this.buttonDuration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            this.panelActorsBackground.SuspendLayout();
            this.panelFilmBackground.SuspendLayout();
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
            this.buttonFilms.Location = new System.Drawing.Point(36, 89);
            this.buttonFilms.Name = "buttonFilms";
            this.buttonFilms.Size = new System.Drawing.Size(137, 31);
            this.buttonFilms.TabIndex = 2;
            this.buttonFilms.Text = "Pokaż filmy";
            this.buttonFilms.UseVisualStyleBackColor = true;
            this.buttonFilms.Click += new System.EventHandler(this.buttonFilms_Click);
            // 
            // labelActorBirthDate
            // 
            this.labelActorBirthDate.AutoSize = true;
            this.labelActorBirthDate.Location = new System.Drawing.Point(3, 95);
            this.labelActorBirthDate.Name = "labelActorBirthDate";
            this.labelActorBirthDate.Size = new System.Drawing.Size(79, 13);
            this.labelActorBirthDate.TabIndex = 20;
            this.labelActorBirthDate.Text = "Data urodzenia";
            // 
            // labelActorSurname
            // 
            this.labelActorSurname.AutoSize = true;
            this.labelActorSurname.Location = new System.Drawing.Point(3, 57);
            this.labelActorSurname.Name = "labelActorSurname";
            this.labelActorSurname.Size = new System.Drawing.Size(53, 13);
            this.labelActorSurname.TabIndex = 19;
            this.labelActorSurname.Text = "Nazwisko";
            // 
            // dateTimePickerActorBirthDate
            // 
            this.dateTimePickerActorBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerActorBirthDate.Location = new System.Drawing.Point(88, 89);
            this.dateTimePickerActorBirthDate.Name = "dateTimePickerActorBirthDate";
            this.dateTimePickerActorBirthDate.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerActorBirthDate.TabIndex = 17;
            // 
            // textBoxActorSurname
            // 
            this.textBoxActorSurname.Location = new System.Drawing.Point(88, 54);
            this.textBoxActorSurname.Name = "textBoxActorSurname";
            this.textBoxActorSurname.Size = new System.Drawing.Size(109, 20);
            this.textBoxActorSurname.TabIndex = 16;
            // 
            // textBoxActorName
            // 
            this.textBoxActorName.Location = new System.Drawing.Point(88, 18);
            this.textBoxActorName.Name = "textBoxActorName";
            this.textBoxActorName.Size = new System.Drawing.Size(109, 20);
            this.textBoxActorName.TabIndex = 15;
            // 
            // buttonSurnameLike
            // 
            this.buttonSurnameLike.Location = new System.Drawing.Point(88, 127);
            this.buttonSurnameLike.Name = "buttonSurnameLike";
            this.buttonSurnameLike.Size = new System.Drawing.Size(118, 32);
            this.buttonSurnameLike.TabIndex = 13;
            this.buttonSurnameLike.Text = "Znajdź po nazwisku";
            this.buttonSurnameLike.UseVisualStyleBackColor = true;
            this.buttonSurnameLike.Click += new System.EventHandler(this.buttonSurnameLike_Click);
            // 
            // buttonActors
            // 
            this.buttonActors.Location = new System.Drawing.Point(4, 165);
            this.buttonActors.Name = "buttonActors";
            this.buttonActors.Size = new System.Drawing.Size(203, 32);
            this.buttonActors.TabIndex = 12;
            this.buttonActors.Text = "Wszyscy aktorzy";
            this.buttonActors.UseVisualStyleBackColor = true;
            this.buttonActors.Click += new System.EventHandler(this.buttonActors_Click);
            // 
            // buttonActorInsert
            // 
            this.buttonActorInsert.Location = new System.Drawing.Point(4, 127);
            this.buttonActorInsert.Name = "buttonActorInsert";
            this.buttonActorInsert.Size = new System.Drawing.Size(78, 32);
            this.buttonActorInsert.TabIndex = 14;
            this.buttonActorInsert.Text = "Dodaj aktora";
            this.buttonActorInsert.UseVisualStyleBackColor = true;
            this.buttonActorInsert.Click += new System.EventHandler(this.buttonActorInsert_Click);
            // 
            // labelActorName
            // 
            this.labelActorName.AutoSize = true;
            this.labelActorName.Location = new System.Drawing.Point(3, 21);
            this.labelActorName.Name = "labelActorName";
            this.labelActorName.Size = new System.Drawing.Size(26, 13);
            this.labelActorName.TabIndex = 18;
            this.labelActorName.Text = "Imię";
            // 
            // panelActorsBackground
            // 
            this.panelActorsBackground.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelActorsBackground.Controls.Add(this.buttonActors);
            this.panelActorsBackground.Controls.Add(this.labelActorName);
            this.panelActorsBackground.Controls.Add(this.buttonSurnameLike);
            this.panelActorsBackground.Controls.Add(this.buttonActorInsert);
            this.panelActorsBackground.Controls.Add(this.labelActorBirthDate);
            this.panelActorsBackground.Controls.Add(this.textBoxActorName);
            this.panelActorsBackground.Controls.Add(this.dateTimePickerActorBirthDate);
            this.panelActorsBackground.Controls.Add(this.textBoxActorSurname);
            this.panelActorsBackground.Controls.Add(this.labelActorSurname);
            this.panelActorsBackground.Location = new System.Drawing.Point(61, 323);
            this.panelActorsBackground.Name = "panelActorsBackground";
            this.panelActorsBackground.Size = new System.Drawing.Size(209, 203);
            this.panelActorsBackground.TabIndex = 21;
            // 
            // panelFilmBackground
            // 
            this.panelFilmBackground.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFilmBackground.Controls.Add(this.labelFilmDuration);
            this.panelFilmBackground.Controls.Add(this.labelFilmName);
            this.panelFilmBackground.Controls.Add(this.textBoxFilmDuration);
            this.panelFilmBackground.Controls.Add(this.buttonFilms);
            this.panelFilmBackground.Controls.Add(this.textBoxFilmName);
            this.panelFilmBackground.Controls.Add(this.buttonNameLike);
            this.panelFilmBackground.Controls.Add(this.buttonDuration);
            this.panelFilmBackground.Controls.Add(this.button1);
            this.panelFilmBackground.Location = new System.Drawing.Point(314, 323);
            this.panelFilmBackground.Name = "panelFilmBackground";
            this.panelFilmBackground.Size = new System.Drawing.Size(209, 203);
            this.panelFilmBackground.TabIndex = 22;
            // 
            // labelFilmDuration
            // 
            this.labelFilmDuration.AutoSize = true;
            this.labelFilmDuration.Location = new System.Drawing.Point(3, 57);
            this.labelFilmDuration.Name = "labelFilmDuration";
            this.labelFilmDuration.Size = new System.Drawing.Size(67, 13);
            this.labelFilmDuration.TabIndex = 15;
            this.labelFilmDuration.Text = "Czas trwania";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(15, 21);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(40, 13);
            this.labelFilmName.TabIndex = 14;
            this.labelFilmName.Text = "Nazwa";
            // 
            // textBoxFilmDuration
            // 
            this.textBoxFilmDuration.Location = new System.Drawing.Point(76, 54);
            this.textBoxFilmDuration.Name = "textBoxFilmDuration";
            this.textBoxFilmDuration.Size = new System.Drawing.Size(130, 20);
            this.textBoxFilmDuration.TabIndex = 13;
            // 
            // textBoxFilmName
            // 
            this.textBoxFilmName.Location = new System.Drawing.Point(76, 18);
            this.textBoxFilmName.Name = "textBoxFilmName";
            this.textBoxFilmName.Size = new System.Drawing.Size(130, 20);
            this.textBoxFilmName.TabIndex = 12;
            // 
            // buttonNameLike
            // 
            this.buttonNameLike.Location = new System.Drawing.Point(36, 127);
            this.buttonNameLike.Name = "buttonNameLike";
            this.buttonNameLike.Size = new System.Drawing.Size(137, 31);
            this.buttonNameLike.TabIndex = 11;
            this.buttonNameLike.Text = "Znajdź po nazwie";
            this.buttonNameLike.UseVisualStyleBackColor = true;
            this.buttonNameLike.Click += new System.EventHandler(this.buttonNameLike_Click);
            // 
            // buttonDuration
            // 
            this.buttonDuration.Location = new System.Drawing.Point(36, 165);
            this.buttonDuration.Name = "buttonDuration";
            this.buttonDuration.Size = new System.Drawing.Size(137, 32);
            this.buttonDuration.TabIndex = 10;
            this.buttonDuration.Text = "Znajdź po czasie trwania";
            this.buttonDuration.UseVisualStyleBackColor = true;
            this.buttonDuration.Click += new System.EventHandler(this.buttonDuration_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Wszystkie filmy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 557);
            this.Controls.Add(this.panelFilmBackground);
            this.Controls.Add(this.panelActorsBackground);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.labelMyName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            this.panelActorsBackground.ResumeLayout(false);
            this.panelActorsBackground.PerformLayout();
            this.panelFilmBackground.ResumeLayout(false);
            this.panelFilmBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyName;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.Button buttonFilms;
        private System.Windows.Forms.Label labelActorBirthDate;
        private System.Windows.Forms.Label labelActorSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerActorBirthDate;
        private System.Windows.Forms.TextBox textBoxActorSurname;
        private System.Windows.Forms.TextBox textBoxActorName;
        private System.Windows.Forms.Button buttonSurnameLike;
        private System.Windows.Forms.Button buttonActors;
        private System.Windows.Forms.Button buttonActorInsert;
        private System.Windows.Forms.Label labelActorName;
        private System.Windows.Forms.Panel panelActorsBackground;
        private System.Windows.Forms.Panel panelFilmBackground;
        private System.Windows.Forms.Label labelFilmDuration;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.TextBox textBoxFilmDuration;
        private System.Windows.Forms.TextBox textBoxFilmName;
        private System.Windows.Forms.Button buttonNameLike;
        private System.Windows.Forms.Button buttonDuration;
        private System.Windows.Forms.Button button1;
    }
}

