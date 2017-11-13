using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab1
{
    public partial class Form1Main : Form
    {
        public Form1Main()
        {
            InitializeComponent();
            timerMyTimer.Start();
            
        }

        FormNewWindow myForm;

        /// <summary>
        /// Funkcja obslugujaca przycisk start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkCyan;
            buttonStart.BackColor = Color.BlueViolet;
        }
        /// <summary>
        /// Funkcja zmienia color i tekst innego przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.BackColor = Color.BlueViolet;
            buttonStart.Text = "XD";
        }

        /// <summary>
        /// licznik
        /// </summary>
        int counter = 0;

        /// <summary>
        /// Funkcja przepisuje tekst do innego labela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = " ";
            textBoxResult.Text += textBoxValue.Text;
        }
        /// <summary>
        /// Funkcja dodaje dwie wartosci i wypisuje je
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int result = Int32.Parse(textBoxValue1.Text) + Int32.Parse(textBoxValue2.Text);
            textBoxValue3.Text = result.ToString();
        }
        /// <summary>
        /// Funkcja timera zmienia kolory textBoxa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMyTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            textBoxTimer.Text = counter.ToString();
            if(counter%2 == 0)
            {
                textBoxTimer.BackColor = Color.Aqua;
            }else textBoxTimer.BackColor = Color.Aquamarine;
        }
        /// <summary>
        /// Funkcja wywoluje nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            myForm = new FormNewWindow();
            myForm.Show();
        }
    }
}
