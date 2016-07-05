using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    public static class Query
    {
        #region CREATE_TABLES

        public static string CREATE_TABLE_TYPES = "CREATE TABLE IF NOT EXISTS types (type_id INT PRIMARY KEY, name VARCHAR(50))";
        public static string CREATE_TABLE_PRODUCTS = "CREATE TABLE IF NOT EXISTS products (product_id INT PRIMARY KEY, item VARCHAR(100), unit VARCHAR(10), type INT, minimum_stock FLOAT, current_stock FLOAT, price FLOAT, FOREIGN KEY(type) REFERENCES types(type_id))";
        public static string CREATE_TABLE_USERS = "CREATE TABLE IF NOT EXISTS users (user_id INT PRIMARY KEY, username VARCHAR(10) UNIQUE, password VARCHAR(100))";

        #endregion

        #region FUNCTIONS

        public static string Login(string user, string password)
        {
            return "SELECT user_id FROM users WHERE username='" + user + "' AND password='" + password + "'";
        }

        #endregion

    }
}
