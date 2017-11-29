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

namespace zad_1
{
    public partial class FormMyForm : Form
    {
        SqlConnection sqlConnection;
        public FormMyForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-F26UD2M\\SQLEXPRESS; database=Wypożyczalnia_samochodów; Trusted_Connection=yes");
        }
        /// <summary>
        /// Przycisk wywołujący metode pokazującą w dataGridView wszytkie samochody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCars_Click(object sender, EventArgs e)
        {
            Samochody.ShowCars(sqlConnection, dataGridViewTable);
        }
        /// <summary>
        /// Przycisk wywołujący metode dodającą nowy samochód do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Samochody.AddCar(sqlConnection, dataGridViewTable, textBoxMark.Text, textBoxAge.Text, textBoxMileage.Text, textBoxColor.Text, Int32.Parse(textBoxIDKlient.Text));
        }
        /// <summary>
        /// Przycisk wywołujący metode usuwającą samochód z bazy danych z zadanym IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            Samochody.DeleteCar(sqlConnection, dataGridViewTable, Int32.Parse(textBoxID.Text));
        }
        /// <summary>
        /// Przycisk wywołujący metode zmieniają dane o aucie w bazie danych z zadanym IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeCarClick(object sender, EventArgs e)
        {
            if(textBoxMark.Text == "" || textBoxAge.Text == "" || textBoxMileage.Text == "" || textBoxColor.Text == "" || textBoxID.Text == "")
            {
                MessageBox.Show("Musisz podać wszystkie potrzebne dane!");
            }
            else Samochody.ChangeCar(sqlConnection, dataGridViewTable, textBoxMark.Text, textBoxAge.Text, textBoxMileage.Text, textBoxColor.Text, Int32.Parse(textBoxID.Text), Int32.Parse(textBoxIDKlient.Text));
        }
        /// <summary>
        /// Przycisk wywołujący metode pokazującą kluby w dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowClubs_Click(object sender, EventArgs e)
        {
            Kluby.ShowClubs(sqlConnection, dataGridViewTable);
        }
        /// <summary>
        /// Przycisk wywołujący metode pokazującą wszystkie ksiązki w dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowLibrary_Click(object sender, EventArgs e)
        {
            Biblioteka.ShowLibrary(sqlConnection, dataGridViewTable);
        }
        /// <summary>
        /// Przycisk wywołujący metode pokazującą kluby w zależności od posiadanej gotówki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindPerPrice_Click(object sender, EventArgs e)
        {
            Kluby.FindPerPrice(sqlConnection, dataGridViewTable, textBoxPrice.Text);
        }
    }
}
