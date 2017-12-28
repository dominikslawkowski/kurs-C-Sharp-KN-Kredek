using System;
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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();

            //schowanie kursora
            Cursor.Hide();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {   
                panelShip.Left -= 10;
            }

            if (e.KeyCode == Keys.Right)
            {
                panelShip.Left += 10;
            }

            if (e.KeyCode == Keys.Space)
            {
                Shoot();
            }

        }

        private void Shoot()
        {
            Panel laser = new Panel();
            laser.SetBounds(panelShip.Left, panelShip.Top, 5, 50);
            laser.BackColor = Color.Azure;
            laser.Visible = true;
           
            laser.Show();

            while(laser.Top <= 0 || laser.Top <= panelEnemy1.Bottom)
            {
                laser.Top -= 10;
            }
        }
    }
}
