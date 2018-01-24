using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSławkowskiEgzamin
{
    public partial class FormMain : Form
    {

        DataClassesMyDatabaseDataContext context = new DataClassesMyDatabaseDataContext();
        DataGridView myDataGridView = new DataGridView();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja liczaca ilosc znakow #
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPolicz_Click(object sender, EventArgs e)
        {
            int iloscZnakow = 0;
            string ciag = textBoxPolicz.Text;

            foreach(char znak in ciag)
            {
                if (znak == '#') iloscZnakow++;
            }
            MessageBox.Show("Ilosc znakow # : " + iloscZnakow);
        }

        /// <summary>
        /// Funkcja zmniejszajaca szerokosc okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLewo_Click(object sender, EventArgs e)
        {
            if(this.Width >= 100)
            this.Width -= this.Width / 10;
        }

        /// <summary>
        /// Funkcja zwiekszajaca szerokosc okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrawo_Click(object sender, EventArgs e)
        {
            if(this.Width <= 1000)
            this.Width += this.Width / 10;
        }

        /// <summary>
        /// Funkcja startujaca timer dla paska postepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPasekPostepu_Click(object sender, EventArgs e)
        {
            timerPasekPostepu.Start();
        }

        /// <summary>
        /// Timer inkrementujacy pasek postepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPasekPostepu_Tick(object sender, EventArgs e)
        {
            progressBarPasekPostepu.Value += 1;
        }

        /// <summary>
        /// Funkcja wyswietlajaca pracownikow z e w imieniu
        /// </summary>
        private void PokazPracownikow()
        {
            var employees = from employee in context.Employees select new { name = employee.FirstName };
            dataGridViewMain.DataSource = employees;
        }

        /// <summary>
        /// Przycisk wywolujacy funkcje PokazPracowanikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPracownicy_Click(object sender, EventArgs e)
        {
            PokazPracownikow();
        }

        /// <summary>
        /// Funkcja pokazujaca produkty o wartosci (10,15)
        /// </summary>
        private void PokazProdukty()
        {
            var produkts = from produkt in context.Products where produkt.UnitPrice > 10 && produkt.UnitPrice < 15 select new { produkt = produkt.ProductName };
            dataGridViewMain.DataSource = produkts;
        }

        /// <summary>
        /// Przycisk wywolujcy funckje PokazProdukty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProdukty_Click(object sender, EventArgs e)
        {
            PokazProdukty();
        }
    }
}
