using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab3
{
    class Actor
    {
        /// <summary>
        /// Metoda pobiera wszystkich aktorow z bazy danych i odswieza tabele, po czym ja zwraca
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable GetAll(SqlConnection connection)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Actor", connection);
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda pobiera wszystkich aktorow o zadanym nazwisku z bazy danych i odswieza tabele, po czym ja zwraca
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static DataTable GetActorsWhereSurnameLike(SqlConnection connection, string pattern)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Actor where Surname like '%{pattern}%'", connection);
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda dodaje aktora do bazy danych, po czym zwraca wynik dzialania metody GetAll czyli tabele
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DataTable InsertActor(SqlConnection connection, string name, string surname, string date)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO Actor (Name, Surname, BirthDate) values ('{name}','{surname}','{date}')", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return GetAll(connection);
        }
    }
}
