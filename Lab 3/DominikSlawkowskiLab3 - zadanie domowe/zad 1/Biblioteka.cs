using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zad_1
{
    class Biblioteka
    {

        /// <summary>
        /// Wyświetlanie tabeli
        /// </summary>
        /// <param name="sqlDataAdapter"></param>
        /// <param name="dataGridView"></param>
        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }
        /// <summary>
        /// Funkcja wyswietla dane o ksiazkach
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowLibrary(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Biblioteka.ID AS ID, Nazwa AS Nazwa, Autor AS Autor, Imię AS Imię, Nazwisko AS Nazwisko, Klasa AS Klasa FROM Biblioteka
               JOIN Uczniowie ON Biblioteka.IDUcznia = Uczniowie.ID;", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}

