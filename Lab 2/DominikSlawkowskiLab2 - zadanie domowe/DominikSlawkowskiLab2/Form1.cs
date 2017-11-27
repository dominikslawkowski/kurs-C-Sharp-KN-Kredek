using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab2
{
    public partial class FormGame : Form
    {
        /// <summary>
        /// Wstępne zainicjowanie obiektów klasy Knight i Skeleton
        /// </summary>
        Knight knight;
        Skeleton skeleton = new Skeleton();

        public FormGame()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Metoda sluzaca do przelaczenia widoku ekranu, oraz wystartowania timerow
        /// </summary>
        void ChangeView()
        {
            labelName.Visible = false;
            comboBoxClass.Visible = false;
            labelClass.Visible = false;
            textBoxName.Visible = false;
            buttonStart.Visible = false;

            labelPlayer.Visible = true;
            labelEnemy.Visible = true;
            panelPlayer.Visible = true;
            panelEnemy.Visible = true;
            labelPlayer.Visible = true;
            labelEnemy.Visible = true;
            progressBarEnemyHealth.Visible = true;
            progressBarPlayerHealth.Visible = true;
            buttonAttack.Visible = true;
            buttonRest.Visible = true;
            buttonStrongAttack.Visible = true;
            labelInfo.Visible = true;
            labelInfoTitle.Visible = true;

            labelPlayer.Text = textBoxName.Text;
            timerEnemyAttack.Start();
            timerCheckWhoIsDead.Start();
        }
        /// <summary>
        /// Metoda wywolywana po zatwierdzeniu danych w pierwszym oknie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(comboBoxClass.Text == "Rycerz")
            {
                knight = new Knight(labelName.Text);
              
                ChangeView();
            }
            if (comboBoxClass.Text == "Mag")
            {
                knight = new Knight(labelName.Text);
                
                ChangeView();
            }
            else if(comboBoxClass.Text == "")
            { MessageBox.Show("Musisz wybrac klase postaci!"); }
        }

        /// <summary>
        /// Metoda wywolywana po kliknieciu w buttonAttack, sprawadza ilosc zycia przeciwnika i zadaje mu obrazenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (skeleton.IsDead() == false)
            {
                int damage = knight.LightSwordAttack(skeleton);
                if (damage > progressBarEnemyHealth.Value) progressBarEnemyHealth.Value = 0;
                else
                {
                    progressBarEnemyHealth.Value -= damage;
                    labelInfo.Text = "Zaatakowales przeciwanika za: " + damage;
                }
            }
        }
        /// <summary>
        /// Metoda wywolywana po kliknieciu w buttonStrongAttack, sprawadza ilosc zycia przeciwnika i zadaje mu obrazenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrongAttack_Click(object sender, EventArgs e)
        {
            if (skeleton.IsDead() == false)
            {
                int damage = knight.StrongSwordAttack(skeleton);
                if (damage > progressBarEnemyHealth.Value) progressBarEnemyHealth.Value = 0;
                else
                {
                    progressBarEnemyHealth.Value -= damage;
                    labelInfo.Text = "Zaatakowales przeciwanika za: " + damage;
                }
            }
        }
        /// <summary>
        /// Timer wywoluje metode klasy Enemy ktora zadaje obrazenia naszej postaci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEnemyAttack_Tick(object sender, EventArgs e)
        {
            if (knight.IsDead() == false)
            {
                int damage = skeleton.SwordAttack(knight);
                if (damage > progressBarPlayerHealth.Value) progressBarPlayerHealth.Value = 0;
                else
                {
                    progressBarPlayerHealth.Value -= damage;
                    labelInfo.Text = "Przeciwnik zaatakowal Cie za:" + damage;
                }
             }
        }
        /// <summary>
        /// Metoda dzieki ktorej mozemy sie leczyc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRest_Click(object sender, EventArgs e)
        {
            int buff = knight.TakeRest();
            progressBarPlayerHealth.Value += buff;
            labelInfo.Text = "Uzdrowiles sie za: " + buff;
        }

       /// <summary>
       /// Timer sprawdzajacy czy ktoras z postaci nie umarla, aby w razie potrzeby zakonczyc gre
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        public void timerCheckWhoIsDead_Tick(object sender, EventArgs e)
        {
            if(knight.IsDead())
            {
                timerCheckWhoIsDead.Stop();
                timerEnemyAttack.Stop();

                MessageBox.Show("Przegrales!");
            }
            if(skeleton.IsDead())
            {
                timerCheckWhoIsDead.Stop();
                timerEnemyAttack.Stop();
                buttonAttack.Visible = false;
                buttonStrongAttack.Visible = false;

                MessageBox.Show("Wygrales!");
            }
        }
    }
}
