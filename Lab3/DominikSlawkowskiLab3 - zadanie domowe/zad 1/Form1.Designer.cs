namespace zad_1
{
    partial class FormMyForm
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
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonPokażSamochody = new System.Windows.Forms.Button();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelPrzebieg = new System.Windows.Forms.Label();
            this.labelRocznik = new System.Windows.Forms.Label();
            this.labelKolor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonZmień = new System.Windows.Forms.Button();
            this.buttonUsuń = new System.Windows.Forms.Button();
            this.panelID = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.panelTło = new System.Windows.Forms.Panel();
            this.textBoxIDKlient = new System.Windows.Forms.TextBox();
            this.labelIDKlienta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelWyszkukiwanie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBiblioteka = new System.Windows.Forms.Button();
            this.pictureBoxKluby = new System.Windows.Forms.PictureBox();
            this.buttonPokażKluby = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panelID.SuspendLayout();
            this.panelTło.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKluby)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowTemplate.Height = 28;
            this.dataGridViewTable.Size = new System.Drawing.Size(733, 170);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // buttonPokażSamochody
            // 
            this.buttonPokażSamochody.Location = new System.Drawing.Point(21, 183);
            this.buttonPokażSamochody.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPokażSamochody.Name = "buttonPokażSamochody";
            this.buttonPokażSamochody.Size = new System.Drawing.Size(144, 30);
            this.buttonPokażSamochody.TabIndex = 16;
            this.buttonPokażSamochody.Text = "Samochody";
            this.buttonPokażSamochody.UseVisualStyleBackColor = true;
            this.buttonPokażSamochody.Click += new System.EventHandler(this.buttonShowCars_Click);
            // 
            // textBoxMarka
            // 
            this.textBoxMark.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMark.Location = new System.Drawing.Point(69, 15);
            this.textBoxMark.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMark.Name = "textBoxMarka";
            this.textBoxMark.Size = new System.Drawing.Size(97, 20);
            this.textBoxMark.TabIndex = 17;
            // 
            // textBoxPrzebieg
            // 
            this.textBoxMileage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMileage.Location = new System.Drawing.Point(69, 86);
            this.textBoxMileage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMileage.Name = "textBoxPrzebieg";
            this.textBoxMileage.Size = new System.Drawing.Size(97, 20);
            this.textBoxMileage.TabIndex = 18;
            // 
            // textBoxRocznik
            // 
            this.textBoxAge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxAge.Location = new System.Drawing.Point(69, 49);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAge.Name = "textBoxRocznik";
            this.textBoxAge.Size = new System.Drawing.Size(97, 20);
            this.textBoxAge.TabIndex = 19;
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarka.Location = new System.Drawing.Point(13, 15);
            this.labelMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(45, 15);
            this.labelMarka.TabIndex = 20;
            this.labelMarka.Text = "Marka:";
            // 
            // labelPrzebieg
            // 
            this.labelPrzebieg.AutoSize = true;
            this.labelPrzebieg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrzebieg.Location = new System.Drawing.Point(13, 86);
            this.labelPrzebieg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrzebieg.Name = "labelPrzebieg";
            this.labelPrzebieg.Size = new System.Drawing.Size(59, 15);
            this.labelPrzebieg.TabIndex = 21;
            this.labelPrzebieg.Text = "Przebieg:";
            // 
            // labelRocznik
            // 
            this.labelRocznik.AutoSize = true;
            this.labelRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRocznik.Location = new System.Drawing.Point(13, 49);
            this.labelRocznik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRocznik.Name = "labelRocznik";
            this.labelRocznik.Size = new System.Drawing.Size(54, 15);
            this.labelRocznik.TabIndex = 22;
            this.labelRocznik.Text = "Rocznik:";
            // 
            // labelKolor
            // 
            this.labelKolor.AutoSize = true;
            this.labelKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolor.Location = new System.Drawing.Point(13, 122);
            this.labelKolor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKolor.Name = "labelKolor";
            this.labelKolor.Size = new System.Drawing.Size(39, 15);
            this.labelKolor.TabIndex = 23;
            this.labelKolor.Text = "Kolor:";
            // 
            // textBoxKolor
            // 
            this.textBoxColor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxColor.Location = new System.Drawing.Point(69, 120);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxColor.Name = "textBoxKolor";
            this.textBoxColor.Size = new System.Drawing.Size(97, 20);
            this.textBoxColor.TabIndex = 24;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(189, 9);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(81, 30);
            this.buttonDodaj.TabIndex = 25;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonZmień
            // 
            this.buttonZmień.Location = new System.Drawing.Point(6, 49);
            this.buttonZmień.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZmień.Name = "buttonZmień";
            this.buttonZmień.Size = new System.Drawing.Size(81, 30);
            this.buttonZmień.TabIndex = 26;
            this.buttonZmień.Text = "Zmień";
            this.buttonZmień.UseVisualStyleBackColor = true;
            this.buttonZmień.Click += new System.EventHandler(this.buttonChangeCarClick);
            // 
            // buttonUsuń
            // 
            this.buttonUsuń.Location = new System.Drawing.Point(6, 8);
            this.buttonUsuń.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUsuń.Name = "buttonUsuń";
            this.buttonUsuń.Size = new System.Drawing.Size(81, 30);
            this.buttonUsuń.TabIndex = 27;
            this.buttonUsuń.Text = "Usuń";
            this.buttonUsuń.UseVisualStyleBackColor = true;
            this.buttonUsuń.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // panelID
            // 
            this.panelID.BackColor = System.Drawing.Color.DarkGray;
            this.panelID.Controls.Add(this.textBoxID);
            this.panelID.Controls.Add(this.labelID);
            this.panelID.Controls.Add(this.buttonUsuń);
            this.panelID.Controls.Add(this.buttonZmień);
            this.panelID.Location = new System.Drawing.Point(183, 49);
            this.panelID.Margin = new System.Windows.Forms.Padding(2);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(93, 151);
            this.panelID.TabIndex = 28;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxID.Location = new System.Drawing.Point(6, 122);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(82, 20);
            this.textBoxID.TabIndex = 29;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 100);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 13);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "Podaj ID:";
            // 
            // panelTło
            // 
            this.panelTło.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTło.Controls.Add(this.textBoxIDKlient);
            this.panelTło.Controls.Add(this.labelIDKlienta);
            this.panelTło.Controls.Add(this.button1);
            this.panelTło.Controls.Add(this.textBoxPrice);
            this.panelTło.Controls.Add(this.labelWyszkukiwanie);
            this.panelTło.Controls.Add(this.pictureBox1);
            this.panelTło.Controls.Add(this.buttonBiblioteka);
            this.panelTło.Controls.Add(this.pictureBoxKluby);
            this.panelTło.Controls.Add(this.buttonPokażKluby);
            this.panelTło.Controls.Add(this.textBoxColor);
            this.panelTło.Controls.Add(this.panelID);
            this.panelTło.Controls.Add(this.buttonPokażSamochody);
            this.panelTło.Controls.Add(this.buttonDodaj);
            this.panelTło.Controls.Add(this.textBoxMark);
            this.panelTło.Controls.Add(this.textBoxMileage);
            this.panelTło.Controls.Add(this.labelKolor);
            this.panelTło.Controls.Add(this.textBoxAge);
            this.panelTło.Controls.Add(this.labelRocznik);
            this.panelTło.Controls.Add(this.labelMarka);
            this.panelTło.Controls.Add(this.labelPrzebieg);
            this.panelTło.Location = new System.Drawing.Point(9, 190);
            this.panelTło.Margin = new System.Windows.Forms.Padding(2);
            this.panelTło.Name = "panelTło";
            this.panelTło.Size = new System.Drawing.Size(733, 244);
            this.panelTło.TabIndex = 29;
            // 
            // textBoxIDKlienta
            // 
            this.textBoxIDKlient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxIDKlient.Location = new System.Drawing.Point(101, 152);
            this.textBoxIDKlient.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDKlient.Name = "textBoxIDKlienta";
            this.textBoxIDKlient.Size = new System.Drawing.Size(33, 20);
            this.textBoxIDKlient.TabIndex = 37;
            // 
            // labelIDKlienta
            // 
            this.labelIDKlienta.AutoSize = true;
            this.labelIDKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIDKlienta.Location = new System.Drawing.Point(13, 153);
            this.labelIDKlienta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDKlienta.Name = "labelIDKlienta";
            this.labelIDKlienta.Size = new System.Drawing.Size(66, 15);
            this.labelIDKlienta.TabIndex = 36;
            this.labelIDKlienta.Text = "ID Klienta: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Wyszukaj klub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFindPerPrice_Click);
            // 
            // textBoxGwiazdki
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPrice.Location = new System.Drawing.Point(627, 107);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxGwiazdki";
            this.textBoxPrice.Size = new System.Drawing.Size(82, 20);
            this.textBoxPrice.TabIndex = 30;
            // 
            // labelWyszkukiwanie
            // 
            this.labelWyszkukiwanie.AutoSize = true;
            this.labelWyszkukiwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWyszkukiwanie.Location = new System.Drawing.Point(627, 68);
            this.labelWyszkukiwanie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWyszkukiwanie.Name = "labelWyszkukiwanie";
            this.labelWyszkukiwanie.Size = new System.Drawing.Size(94, 30);
            this.labelWyszkukiwanie.TabIndex = 34;
            this.labelWyszkukiwanie.Text = "Ile masz hajsu\r\nna dziś wieczór:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::zad_1.Properties.Resources.SAxktoARGh0dHA6Ly9vY2RuLmV1L25ld3N3ZWVrLXdlYi8wNjY5NDA3ZS1hMjJlLTQ3YWEtOTJmMi02NGJkOWE2NDMxYmUuanBnkZUCAM0CWMLD;
            this.pictureBox1.Location = new System.Drawing.Point(451, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBiblioteka
            // 
            this.buttonBiblioteka.Location = new System.Drawing.Point(451, 142);
            this.buttonBiblioteka.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBiblioteka.Name = "buttonBiblioteka";
            this.buttonBiblioteka.Size = new System.Drawing.Size(144, 30);
            this.buttonBiblioteka.TabIndex = 31;
            this.buttonBiblioteka.Text = "Szkolna biblioteka";
            this.buttonBiblioteka.UseVisualStyleBackColor = true;
            this.buttonBiblioteka.Click += new System.EventHandler(this.buttonShowLibrary_Click);
            // 
            // pictureBoxKluby
            // 
            this.pictureBoxKluby.Image = global::zad_1.Properties.Resources.weekly_forecast1;
            this.pictureBoxKluby.Location = new System.Drawing.Point(288, 34);
            this.pictureBoxKluby.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxKluby.Name = "pictureBoxKluby";
            this.pictureBoxKluby.Size = new System.Drawing.Size(153, 96);
            this.pictureBoxKluby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKluby.TabIndex = 30;
            this.pictureBoxKluby.TabStop = false;
            // 
            // buttonPokażKluby
            // 
            this.buttonPokażKluby.Location = new System.Drawing.Point(293, 142);
            this.buttonPokażKluby.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPokażKluby.Name = "buttonPokażKluby";
            this.buttonPokażKluby.Size = new System.Drawing.Size(144, 30);
            this.buttonPokażKluby.TabIndex = 29;
            this.buttonPokażKluby.Text = "Wrocławskie kluby";
            this.buttonPokażKluby.UseVisualStyleBackColor = true;
            this.buttonPokażKluby.Click += new System.EventHandler(this.buttonShowClubs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.panelTło);
            this.panel1.Controls.Add(this.dataGridViewTable);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 445);
            this.panel1.TabIndex = 30;
            // 
            // FormMyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMyForm";
            this.Text = "Aplikacja z podłączoną bazą danych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panelID.ResumeLayout(false);
            this.panelID.PerformLayout();
            this.panelTło.ResumeLayout(false);
            this.panelTło.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKluby)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button buttonPokażSamochody;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelPrzebieg;
        private System.Windows.Forms.Label labelRocznik;
        private System.Windows.Forms.Label labelKolor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonZmień;
        private System.Windows.Forms.Button buttonUsuń;
        private System.Windows.Forms.Panel panelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panelTło;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPokażKluby;
        private System.Windows.Forms.PictureBox pictureBoxKluby;
        private System.Windows.Forms.Button buttonBiblioteka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelWyszkukiwanie;
        private System.Windows.Forms.TextBox textBoxIDKlient;
        private System.Windows.Forms.Label labelIDKlienta;
    }
}

