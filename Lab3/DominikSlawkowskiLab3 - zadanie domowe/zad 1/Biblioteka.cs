using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_1
{
    class Biblioteka
    {
        private static SqlCommand sqlCommand;

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
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Biblioteka.ID AS ID, Nazwa AS Nazwa, Autor AS Autor, IDUcznia AS IDUcznia FROM Biblioteka
               JOIN Uczniowie ON Biblioteka.IDUcznia = Uczniowie.ID;", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
    }
}
