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
        //inicjalizowanie potrzebnych zmiennych, list i obiektów
        List<Panel> lasersList = new List<Panel>();
        List<Panel> aliensList = new List<Panel>();
        List<Panel> alienLasersList = new List<Panel>();
        List<Object> endPanelList = new List<object>();

        List<int> randList = new List<int>();
        Random value = new Random();
        int i = 0;

        int score = 0;

        Panel laser;
        Panel alienLaser;

        public FormGame()
        {
            InitializeComponent();

            aliensList.Add(panelEnemy1);
            aliensList.Add(panelEnemy2);
            aliensList.Add(panelEnemy3);
            aliensList.Add(panelEnemy4);

            endPanelList.Add(panelEndBackground);
            endPanelList.Add(labelTitle);
            endPanelList.Add(labelScore);
            endPanelList.Add(buttonStart);
            endPanelList.Add(buttonMenu);

            panelEndBackground.Visible = false;
            labelTitle.Visible = false;
            labelScore.Visible = false;
            buttonStart.Visible = false;
            buttonMenu.Visible = false;



            randList.Add(0);

            AlienShoot();

            timerAliens.Start();

            timerRandomisation.Start();

            timerAlienShoot.Start();
        }

        /// <summary>
        /// Poruszanie statkiem na boki przy pomocy strzałek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Strzelanie ze statku przy pomocy spacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funkcja oddawania strzału z naszego statku
        /// </summary>
        private void Shoot()
        {
            laser = new Panel();
            lasersList.Add(laser);

            Controls.Add(laser);
            laser.SetBounds(panelShip.Left + 37, panelShip.Top, 5, 20);

            laser.BackColor = Color.BlueViolet;
            laser.Visible = true;

            timerLasers.Start();
        }

        /// <summary>
        /// Funkcja strzelania do nas z wrogich statków
        /// </summary>
        private void AlienShoot()
        {

            foreach (Panel alien in aliensList)
            {
               
                    alienLaser = new Panel();
                    alienLasersList.Add(alienLaser);

                    Controls.Add(alienLaser);
                    alienLaser.SetBounds(alien.Left + 20, alien.Bottom, 5, 20);

                    alienLaser.BackColor = Color.Coral;
                    alienLaser.Visible = true;  
               
            }



            timerAlienLasers.Start();
        }

        /// <summary>
        /// Timer odpowiedzialny za przemieszczanie naszych pocisków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        alien.SetBounds(Width, Height, 0, 0);
                        alien.Dispose();
                        laser.Dispose();

                        score++;
                    }
                }
                
            }
        }

        /// <summary>
        /// Timer odpowiedzialny za przemieszczanie wrogich pocisków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                        labelScore.Text += score.ToString();

                        timerAlienLasers.Stop();
                        timerAliens.Stop();
                        timerAlienShoot.Stop();
                        timerLasers.Stop();
                        timerRandomisation.Stop();

                        panelEndBackground.Visible = true;
                        labelTitle.Visible = true;
                        labelScore.Visible = true;
                        buttonStart.Visible = true;
                        buttonMenu.Visible = true;
                }


            }
        }

        /// <summary>
        /// Timer odpowiedzialny za przemieszczanie się wrogich statków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAliens_Tick(object sender, EventArgs e)
        {

            foreach(Panel alien in aliensList)
            {
                if(alien.Top <= 200)
                alien.Top += 1;
           
            }

        }

        /// <summary>
        /// Timer dodający losowe wartości do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRandomisation_Tick(object sender, EventArgs e)
        {
            randList.Add(value.Next(1, 10));
            i++;
        }

        /// <summary>
        /// Timer odpowiedzialny za oddawanie strzałów przez wrogie statki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAlienShoot_Tick(object sender, EventArgs e)
        {
            AlienShoot();
        }

        /// <summary>
        /// Funkcja restartu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGame game = new FormGame();
            game.Show();
        }

        /// <summary>
        /// Funkcja zakończenia danej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
