using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace inventario
{
    public class DB
    {
        SQLiteConnection connection;

        public DB()
        {
            this.connection = new SQLiteConnection("Data Source=stock.db;Version=3;");
            initializeDataBase();
        }

        public void initializeDataBase()
        {
            string query;
            SQLiteCommand command;
            connection.Open();
            SQLiteTransaction transaction = connection.BeginTransaction();
            query = Query.CREATE_TABLE_TYPES;
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            query = Query.CREATE_TABLE_PRODUCTS;
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            query = Query.CREATE_TABLE_USERS;
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            query = Query.CREATE_TABLE_USERS;
            command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }

        public int login(string user, string password)
        {
            string query;
            int userId = -1;
            SQLiteCommand command;
            connection.Open();
            query = Query.Login(user,password);
            command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                userId = Convert.ToInt32(reader["user_id"]);
            connection.Close();
            return userId;
        }
    }
}
