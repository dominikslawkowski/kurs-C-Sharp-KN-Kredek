using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab7
{
    public partial class FormMain : Form
    {
        int X;
        int Y;

        DataClassesPositionsDataContext context = new DataClassesPositionsDataContext();
        Graphics graphics;

        public FormMain()
        {
            InitializeComponent();
            graphics = CreateGraphics();

        }
        /// <summary>
        /// Pobranie danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_Click(object sender, EventArgs e)
        {
            var helpers = from helper in context.DominikSlawkowski_Positions select new { ID = helper.ID, X = helper.X, Y = helper.Y, Name = helper.Name};
            dataGridViewTable.DataSource = helpers;
        }
        /// <summary>
        /// Wyslanie danych na serwer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            DominikSlawkowski_Position helper = new DominikSlawkowski_Position();
            helper.X = Int32.Parse(textBoxX.Text);
            helper.Y = Int32.Parse(textBoxY.Text);
            helper.Name = textBoxName.Text;

            context.DominikSlawkowski_Positions.InsertOnSubmit(helper);
            context.SubmitChanges(); //TUTAJ KONIECZNA LINIJKA
        }
        /// <summary>
        /// Pobranie danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFigure_Click(object sender, EventArgs e)
        {
            //czyszczenie kolorem tla systemowego
            graphics.Clear(SystemColors.Control);

            //przypisanie koloru elementu
            SolidBrush brush = new SolidBrush(Color.Black);

            //Stworzenie ksztaltu - prostokat
            graphics.FillRectangle(brush, 200, 200, 300, 200);

        }

        /// <summary>
        /// Przesuwanie w gore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 200, 200 - X, 300, 200);

            X++;

        }
        /// <summary>
        /// Przesuwanie w dol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 200, 200 + X, 300, 200);

            X+=10;
        }
        /// <summary>
        /// Przesuwanie w lewo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 200 - Y, 200, 300, 200);

            Y++;
        }
        /// <summary>
        /// Przesuwanie w prawo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 200 + Y, 200, 300, 200);

            Y++;
        }
        /// <summary>
        /// Zmiana koloru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillRectangle(brush, 200, 200, 300, 200);
        }
        int x = 100;
        int y = 100;
        /// <summary>
        /// timer zmieniajacy polozenie i kolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
            SolidBrush brush = new SolidBrush(Color.FromArgb(100 + x, 100+y, 50));
            graphics.FillRectangle(brush, 200 + y, 200 + x, 300, 200);

            x += 5;
            y += 5;

        }
        /// <summary>
        /// Przycisk startujacy timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAuto_Click(object sender, EventArgs e)
        {
            timerAuto.Start();
        }

        int line = 0;
        int color = 0;
        /// <summary>
        /// Funkcja rysujaca linie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLine_Click(object sender, EventArgs e)
        {
            timerLine.Start();
        }
        /// <summary>
        /// Genrerownie rysunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAuto_Tick_1(object sender, EventArgs e)
        {

            SolidBrush brush = new SolidBrush(Color.FromArgb(100+color, 100-color, 50));
            Pen pen = new Pen(brush);
            graphics.DrawLine(pen, 200 + line, 200 + line, 600 - line, 600);

            line += 20;
            color += 3;
        }

        /// <summary>
        /// Zminimalizowanie programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackground_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIconMonitor.Visible = true;

        }
        /// <summary>
        /// Przywrocenie pracy programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconMonitor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIconMonitor.Visible = false;
        }

        /// <summary>
        /// Przycisk uruchamiajacy nowy proces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\domin\Desktop\website\deadmau5 shop\sklep.html");
        }
    }
}
