using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab3
{
    class Film
    {
        /// <summary>
        /// Metoda pobiera wszystkie filmy z bazy danych i odswieza tabele, po czym ja zwraca
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static DataTable GetAll(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Film", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        /// <summary>
        /// Metoda pobiera z bazy danych filmy o wiekszej dlugosci niz podana w argumencie, odswieza tabele i ja zwraca
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static DataTable GetFilmsWithHigherDuration(SqlConnection connection, int duration)
        {
         
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from Film where Duration > 0{duration}", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda zwraca z bazy danych wszystkie filmy o zadanej nazwie, odswieza tabele i zwraca ja
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static DataTable GetFilmsWhereNameLike(SqlConnection connection, string pattern)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from Film where Name like '%{pattern}%'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
