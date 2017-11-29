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
    class Uczniowie
    {
        /// <summary>
        /// Metoda pokazuje tabele z bazy danych w data/GridView
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
        /// Metoda przekazuje tabele z ocenami pierwszego ucznia
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowGrades1(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT ID AS ID, Matematyka AS Matematyka, [Język polski] AS [Język polski], Przyroda AS Przyroda FROM [Oceny ucznia 1]", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Metoda przekazuje tabele z ocenami drugiego ucznia
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowGrades2(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT ID AS ID, Matematyka AS Matematyka, [Język polski] AS [Język polski], Przyroda AS Przyroda FROM [Oceny ucznia 2]", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Metoda przekazuje tabele z ocenami trzeciego ucznia
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowGrades3(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT ID AS ID, Matematyka AS Matematyka, [Język polski] AS [Język polski], Przyroda AS Przyroda FROM [Oceny ucznia 3]", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

    }
}
