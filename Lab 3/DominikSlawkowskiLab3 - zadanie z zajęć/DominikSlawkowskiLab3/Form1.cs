using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikSlawkowskiLab3
{
    public partial class Form1 : Form
    {
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-F26UD2M\SQLEXPRESS; database=DominikSlawkowskiLab3; Trusted_Connection = yes");
        }

        /// <summary>
        /// Metoda wywołuję metode pobierającą z bazy danych wszystkie filmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFilms_Click(object sender, EventArgs e)
        {
            DataTable table = Film.GetAll(connection);

            dataGridViewFilm.DataSource = table;
        }
        /// <summary>
        /// Metoda wywołuję metodę która pobiera z bazy wszystkich aktorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActors_Click(object sender, EventArgs e)
        {
            DataTable table = Actor.GetAll(connection);

            SetContentInDataGridView(table);
        }
        /// <summary>
        /// Metoda zeruje zasoby w dataGridView i ustawie na zaktualizowane z tabeli z bazy danych
        /// </summary>
        /// <param name="table"></param>
        private void SetContentInDataGridView(DataTable table)
        {
            dataGridViewFilm.DataSource = null;
            dataGridViewFilm.DataSource = table;
        }
        /// <summary>
        /// Metoda wywołuję metodę która dodaję aktora do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonActorInsert_Click(object sender, EventArgs e)
        {
            DataTable table = Actor.InsertActor(connection, textBoxActorName.Text, textBoxActorSurname.Text, dateTimePickerActorBirthDate.Value.ToString("yyyy-MM-dd"));
            SetContentInDataGridView(table);
        }
        /// <summary>
        /// Metoda wywołuję metodę która pobiera aktorów z bazy danych wybierając po nazwisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSurnameLike_Click(object sender, EventArgs e)
        {
            DataTable table = Actor.GetActorsWhereSurnameLike(connection, textBoxActorSurname.Text);
            SetContentInDataGridView(table);
        }
        /// <summary>
        /// Metoda wywołuję metodę która wybiera filmy z bazy danych wybierając po nazwie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNameLike_Click(object sender, EventArgs e)
        {
            DataTable table = Film.GetFilmsWhereNameLike(connection, textBoxFilmName.Text);
            SetContentInDataGridView(table);
        }
        /// <summary>
        /// Metoda jeśli podana dlugość nie jest pusta wywołuję metodę która pobiera filmy z bazy danych o wiekszej dlugosci niz podana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDuration_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFilmDuration.Text))
            {
                DataTable table = Film.GetFilmsWithHigherDuration(connection, Int32.Parse(textBoxFilmDuration.Text));
                SetContentInDataGridView(table);
            }
        }
    }
}
