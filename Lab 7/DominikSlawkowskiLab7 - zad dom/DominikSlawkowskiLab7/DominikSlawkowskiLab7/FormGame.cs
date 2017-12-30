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
        List<Panel> lasersList = new List<Panel>();
        List<Panel> aliensList = new List<Panel>();
        List<Panel> alienLasersList = new List<Panel>();

        List<int> randList = new List<int>();
        Random value = new Random();
        int i = 0;

        Panel laser;
        Panel alienLaser;

        public FormGame()
        {
            InitializeComponent();

            aliensList.Add(panelEnemy1);
            aliensList.Add(panelEnemy2);
            aliensList.Add(panelEnemy3);
            aliensList.Add(panelEnemy4);

            randList.Add(0);
            //schowanie kursora
            // Cursor.Hide();

            AlienShoot();

            timerAliens.Start();

            timerRandomisation.Start();

            timerAlienShoot.Start();
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

        }

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                Shoot();
            }

            if(e.KeyChar == 'q')
            {
                AlienShoot();
            }
        }

        private void Shoot()
        {
            laser = new Panel();
            lasersList.Add(laser);

            Controls.Add(laser);
            laser.SetBounds(panelShip.Left + 37, panelShip.Top - 40, 5, 20);

            laser.BackColor = Color.BlueViolet;
            laser.Visible = true;

            timerLasers.Start();
        }

        private void AlienShoot()
        {

            foreach (Panel alien in aliensList)
            {
               
                    alienLaser = new Panel();
                    alienLasersList.Add(alienLaser);

                    Controls.Add(alienLaser);
                    alienLaser.SetBounds(alien.Left + 20, alien.Bottom + 10, 5, 20);

                    alienLaser.BackColor = Color.Coral;
                    alienLaser.Visible = true;  
               
            }



            timerAlienLasers.Start();
        }

        private void timerLasers_Tick(object sender, EventArgs e)
        {
            foreach (Panel laser in lasersList)
            {
                if (laser.Top >= 0) laser.Top -= 4;
                else laser.Dispose();

                foreach (Panel alien in aliensList)
                {
                    if(laser.Top <= alien.Bottom && laser.Bottom >= alien.Top && laser.Right <= alien.Right && laser.Left >= alien.Left)
                    {
                        alien.SetBounds(Width,Height,0,0);
                        alien.Dispose();
                        laser.Dispose();
                    }
                }
                
            }
        }

        private void timerAlienLasers_Tick(object sender, EventArgs e)
        {
            foreach (Panel alienLaser in alienLasersList)
            {
                if (alienLaser.Bottom <= this.Height) alienLaser.Top += 4;
                else alienLaser.Dispose();

                    if (alienLaser.Bottom >= panelShip.Top && alienLaser.Top <= panelShip.Bottom && alienLaser.Right <= panelShip.Right && alienLaser.Left >= panelShip.Left)
                    {
                        panelShip.Dispose();
                        alienLaser.Dispose();
                    }


            }
        }

        private void timerAliens_Tick(object sender, EventArgs e)
        {

            foreach(Panel alien in aliensList)
            {
                if(alien.Top <= 200)
                alien.Top += 1;
                    
            }

        }

        private void timerRandomisation_Tick(object sender, EventArgs e)
        {
            randList.Add(value.Next(1, 10));
            i++;
        }

        private void timerAlienShoot_Tick(object sender, EventArgs e)
        {
            AlienShoot();
        }
    }
}
