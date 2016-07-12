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

		public static string CREATE_TABLE_TYPES = "CREATE TABLE IF NOT EXISTS types (type_id INTEGER PRIMARY KEY, name VARCHAR(50))";
		public static string CREATE_TABLE_PRODUCTS = "CREATE TABLE IF NOT EXISTS products (product_id INTEGER PRIMARY KEY, item VARCHAR(100), unit VARCHAR(10), type INT, minimum_stock FLOAT, current_stock FLOAT, price FLOAT, active BOOLEAN, FOREIGN KEY(type) REFERENCES types(type_id))";
		public static string CREATE_TABLE_USERS = "CREATE TABLE IF NOT EXISTS users (user_id INTEGER PRIMARY KEY, username VARCHAR(10) UNIQUE, password VARCHAR(100), level INT)";
		public static string CREATE_TABLE_SALES = "CREATE TABLE IF NOT EXISTS sales (date DATE, time TIME, product INT, user INT, quantity FLOAT, price FLOAT)";

		#endregion

		public static string INSERT_SUPER_USER = "INSERT INTO users VALUES (NULL, 'siulpolb', 'siulpolb', 0)";

		public static string GET_ALL_PRODUCTS = "SELECT product_id, item, unit, types.name as type, minimum_stock, current_stock, price FROM products, types WHERE products.type = types.type_id AND products.active = 1";

		#region FUNCTIONS

		public static string Login(string user, string password)
        {
            return "SELECT user_id, level FROM users WHERE username='" + user + "' AND password='" + password + "'";
        }

		public static string Sell(int product, double quantity, int user, double price)
		{
			return "INSERT INTO sales VALUES (date('now'),time('now')," + product + "," + user + "," + quantity + "," + price + ")";
		}

		public static string UpdateStock(int product, double quantity)
		{
			return "UPDATE products SET current_stock = current_stock - " + quantity + " WHERE product_id = "+product;
		}

		#endregion

		public static string FILL_TEST_DATA = "INSERT INTO types VALUES(NULL, 'Refrescos');INSERT INTO types VALUES(NULL, 'Salchichoneria');INSERT INTO products VALUES (NULL,'Coca Cola 10 ml', 'pieza',1,5,10,10,1);INSERT INTO products VALUES (NULL,'Rajas 10 gr', 'pieza',1,5,10,5.5,1);";

	}
}
