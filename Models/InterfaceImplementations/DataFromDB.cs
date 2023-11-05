using MusicCatalog.Models.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace MusicCatalog.Models.InterfaceImplementations
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-ATFKTBFE;Initial Catalog=MusicCatalog;Integrated Security=True"); //изменить для своей базы


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
    class DataFromDB : IDataProvider
    {
        public DataTable GetData()
        {
            DataBase db = new DataBase();
            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string querystring = $"select * from songs_db";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            db.closeConnection();
            return dt;
        }
    }
}
