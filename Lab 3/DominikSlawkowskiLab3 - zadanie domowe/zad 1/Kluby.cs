﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zad_1
{
    class Kluby
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
        /// Funkcja wyświetlająca kluby
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowClubs(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT KlubyWrocławskie.ID AS ID, [Nazwa klubu] AS [Nazwa klubu], Położenie AS Położenie, Wstęp AS Wstęp, Opis AS Opis FROM KlubyWrocławskie
               JOIN OpisWrocławskichKlubów ON KlubyWrocławskie.IDOpisu = OpisWrocławskichKlubów.ID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Funkcja wyswietlajaca kluby w dataGridView w zależności od posiadajnej gotówki
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="ilość"></param>
        public static void FindPerPrice(SqlConnection sqlConnection, DataGridView dataGridView, string ilość)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($@"SELECT KlubyWrocławskie.ID AS ID, [Nazwa klubu] AS [Nazwa klubu], Położenie AS Położenie, Wstęp AS Wstęp, Opis AS Opis FROM KlubyWrocławskie
               JOIN OpisWrocławskichKlubów ON KlubyWrocławskie.IDOpisu = OpisWrocławskichKlubów.ID WHERE Wstęp <= {ilość}", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

    }
}
