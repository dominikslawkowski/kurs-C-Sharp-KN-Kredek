﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wyłączenie aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Utworzenie okna z nową grą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
        }

        /// <summary>
        /// Zmiana koloru tła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScores_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
    }
}