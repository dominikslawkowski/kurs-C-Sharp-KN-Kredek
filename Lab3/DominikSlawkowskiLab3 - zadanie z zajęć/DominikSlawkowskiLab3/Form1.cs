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

        private void buttonFilms_Click(object sender, EventArgs e)
        {
            DataTable table = Film.GetAll(connection);

            dataGridViewFilm.DataSource = table;
        }
    }
}
