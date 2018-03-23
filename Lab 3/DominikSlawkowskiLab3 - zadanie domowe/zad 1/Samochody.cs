using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zad_1
{
    class Samochody
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
        /// Funkcja wyświetlająca auta
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        public static void ShowCars(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT Samochody.ID AS ID, Marka AS Marka, Rocznik AS Rocznik, Przebieg AS Przebieg, Kolor AS Kolor, Imię AS Imię, Nazwisko AS Nazwisko FROM Samochody
               JOIN Klienci ON Samochody.IDKlienta = Klienci.ID;", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }
        /// <summary>
        /// Funkcja dodająca auto
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="marka"></param>
        /// <param name="rocznik"></param>
        /// <param name="przebieg"></param>
        /// <param name="kolor"></param>
        public static void AddCar(SqlConnection sqlConnection, DataGridView dataGridView, string marka, string rocznik, string przebieg, string kolor, int IDKlienta)
        {
                sqlConnection.Open();
                string command = $"INSERT INTO Samochody (Marka,Rocznik,Przebieg,Kolor,IDKlienta) values ('{marka}','{rocznik}','{przebieg}','{kolor}','{IDKlienta}')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dodano samochód");
                ShowCars(sqlConnection, dataGridView);
                sqlConnection.Close();
        }
        /// <summary>
        /// Funkcja usuwająca auto
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="ID"></param>
        public static void DeleteCar(SqlConnection sqlConnection, DataGridView dataGridView, int ID)
        {

            sqlConnection.Open();
            string command = $"DELETE FROM Samochody WHERE ID = '{ID}'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Usunięto");
            ShowCars(sqlConnection, dataGridView);
            sqlConnection.Close();

        }
        /// <summary>
        /// Funkcja zmieniająca dane auta
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <param name="dataGridView"></param>
        /// <param name="marka"></param>
        /// <param name="rocznik"></param>
        /// <param name="przebieg"></param>
        /// <param name="kolor"></param>
        /// <param name="id"></param>
        public static void ChangeCar(SqlConnection sqlConnection, DataGridView dataGridView, string marka, string rocznik, string przebieg, string kolor, int ID, int IDKlienta)
        {
                sqlConnection.Open();
                string command = $"UPDATE Samochody SET Marka = '{marka}', Rocznik = '{rocznik}', Przebieg = '{przebieg}', Kolor = '{kolor}', IDKlienta = '{IDKlienta}' WHERE ID = '{ID}'";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Zmieniono dane samochódu");
                ShowCars(sqlConnection, dataGridView);
                sqlConnection.Close();
        }
    }
}
