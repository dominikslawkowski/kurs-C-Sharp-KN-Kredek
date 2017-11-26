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

        private void buttonShowCars_Click(object sender, EventArgs e)
        {
            Samochody.PokażSamochody(sqlConnection, dataGridViewTable);
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            Samochody.AddCar(sqlConnection, dataGridViewTable, textBoxMark.Text, textBoxAge.Text, textBoxMileage.Text, textBoxColor.Text, Int32.Parse(textBoxIDKlient.Text));
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            Samochody.DeleteCar(sqlConnection, dataGridViewTable, Int32.Parse(textBoxID.Text));
        }

        private void buttonChangeCarClick(object sender, EventArgs e)
        {
            Samochody.ChangeCar(sqlConnection, dataGridViewTable, textBoxMark.Text, textBoxAge.Text, textBoxMileage.Text, textBoxColor.Text, Int32.Parse(textBoxID.Text), Int32.Parse(textBoxIDKlient.Text));
        }

        private void buttonShowClubs_Click(object sender, EventArgs e)
        {
            Kluby.ShowClubs(sqlConnection, dataGridViewTable);
        }

        private void buttonShowLibrary_Click(object sender, EventArgs e)
        {
            Biblioteka.ShowLibrary(sqlConnection, dataGridViewTable);
        }

        private void buttonFindPerPrice_Click(object sender, EventArgs e)
        {
            Kluby.FindPerPrice(sqlConnection, dataGridViewTable, textBoxPrice.Text);
        }
    }
}
