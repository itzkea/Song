using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryModel;

namespace SongDL
{
    public class SqlDataBase
    {
        static string connectionString
            = "Data Source = DESKTOP-7NDQCQL; Initial Catalog = Song; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SqlDataBase()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Song> GetSongs()
        {
            string selectStatement = "SELECT Album,Title FROM Songs";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Song> list = new List<Song>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string Album = reader["Album"].ToString();
                string Title = reader["Title"].ToString();

                Song readSong = new Song();
                readSong.Album = Album;
                readSong.Title = Title;

                list.Add(readSong);
            }
            sqlConnection.Close();

            return list;
        }
            public int AddSong(string Album, string Title)

            {
                int success;

                string insertStatement = "INSERT INTO Songs VALUES (@Album, @Title)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);


                insertCommand.Parameters.AddWithValue("@Album", Album);
                insertCommand.Parameters.AddWithValue("@Title", Title);
                sqlConnection.Open();

                success = insertCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return success;

            }

            public int UpdateSong(string Album, string Title)
            {
            int success;

            string updateStatement = $"UPDATE Songs SET Title = @Title WHERE Album = @Album";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Album", Album);
            updateCommand.Parameters.AddWithValue("Title", Title);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

            }

            public int DeleteSong(string Album, string Title)
            {
                int success;

                string deleteStatement = $"UPDATE FROM song WHERE Album = @Album, Title = @Title";
                SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
                sqlConnection.Open();

                deleteCommand.Parameters.AddWithValue("@Album", Album);
                deleteCommand.Parameters.AddWithValue("@Title", Title);

                success = deleteCommand.ExecuteNonQuery();

                sqlConnection.Close();

                return success;

            }





        }

    }

