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
		public static string CREATE_TABLE_PRODUCTS = "CREATE TABLE IF NOT EXISTS products (product_id INTEGER PRIMARY KEY, item VARCHAR(100), unit VARCHAR(10), type INT, minimum_stock FLOAT, current_stock FLOAT, price FLOAT, buy_price FLOAT,active BOOLEAN, FOREIGN KEY(type) REFERENCES types(type_id))";
		public static string CREATE_TABLE_USERS = "CREATE TABLE IF NOT EXISTS users (user_id INTEGER PRIMARY KEY, username VARCHAR(10) UNIQUE, password VARCHAR(100), level INT, active INT)";
		public static string CREATE_TABLE_SALES = "CREATE TABLE IF NOT EXISTS sales (date_time INTEGER, product INT, user INT, quantity FLOAT, price FLOAT)";
		public static string CREATE_TABLE_INCOMES = "CREATE TABLE IF NOT EXISTS incomes (date_time INTEGER, product INT, user INT,  quantity FLOAT, price FLOAT)";
		public static string CREATE_TABLE_LOG = "CREATE TABLE IF NOT EXISTS log (date_time INTEGER, user INT, log TEXT)";

		#endregion

		public static string INSERT_SUPER_USER = "INSERT INTO users VALUES (NULL, 'carlos', 'carlos2016', 255,1)";

		public static string GET_ALL_PRODUCTS = "SELECT product_id, item, unit, types.name as type, minimum_stock, current_stock, price, buy_price FROM products, types WHERE products.type = types.type_id AND products.active = 1";
		public static string GET_TYPES = "SELECT type_id, name from types";
		public static string GET_ALL_LOGS = "SELECT date_time as fecha, date_time as hora, username, log FROM log, users WHERE user=user_id";
		public static string GET_ALL_USERS = "SELECT user_id, username, level from users where active = 1";
		public static string GET_ALL_INCOMES = "SELECT date_time as fecha, date_time as hora, username, item, incomes.quantity, incomes.price FROM incomes, products, users WHERE user=user_id AND product = product_id";
		public static string GET_ALL_SALES = "SELECT date_time as fecha, date_time as hora, username, item, sales.quantity, sales.price FROM sales, products, users WHERE user=user_id AND product = product_id";


		#region FUNCTIONS

		public static string Login(string user, string password)
		{
			return "SELECT user_id, level FROM users WHERE username='" + user + "' AND password='" + password + "' AND active = 1";
		}

		public static string Sell(int product, double quantity, int user, double price)
		{
			return "INSERT INTO sales VALUES (strftime('%s', 'now')," + product + "," + user + "," + quantity + "," + price + ")";
		}

		public static string Buy(int product, double quantity, int user, double price)
		{
			return "INSERT INTO incomes VALUES (strftime('%s', 'now')," + product + "," + user + "," + quantity + "," + price + ")";
		}

		public static string UpdateStock(int product, double quantity, bool increase)
		{
			string query = "UPDATE products SET current_stock = current_stock";
			query += (increase) ? " + " : " - ";
			query += quantity + " WHERE product_id = "+product;
			return query;
		}

		public static string UpdatePrice(int product, double newPrice)
		{
			return "UPDATE products SET price = " + newPrice + " WHERE product_id = " + product;
		}

		public static string UpdateBuyPrice(int product, double newPrice)
		{
			return "UPDATE products SET buy_price = " + newPrice + " WHERE product_id = " + product;
		}

		public static string NewProduct(string name, string unit, double minimum, int type, double sellPrice, double buyPrice)
		{
			return "INSERT INTO products VALUES(NULL, '"+name+"', '"+unit+"',"+type+","+minimum+",0,"+sellPrice+","+buyPrice+",1)";
		}

		public static string NewType(string name)
		{
			return "INSERT INTO types VALUES(NULL,'"+name+"')";
		}

		public static string GetTypeByName(string name)
		{
			return "SELECT type_id FROM types WHERE name = '"+name+"'";
		}

		public static string NewLog(int user, string text)
		{
			return "INSERT INTO log VALUES (strftime('%s', 'now')," + user+",'"+text+"')";
		}

		public static string GetLogs(string initDate, string endDate)
		{
			return "SELECT date_time as fecha, date_time as hora, username, log FROM log, users WHERE user=user_id AND "+ "fecha >= '"+initDate+"' AND fecha <= '"+endDate+"'";
		}

		public static string UpdateUser(int user, string password, int level, int active)
		{
			string query = "UPDATE users SET level = "+level+", active = "+active;
			if (password != "")
				query += ", password ='"+password+"'";
			query += " WHERE user_id = "+user;
			return query;
		}

		public static string NewUser(string username, string password, int level)
		{
			return "INSERT INTO users VALUES(NULL,'"+username+"','"+password+"',"+level+",1)";
		}

		public static string GetSales(string initDate, string endDate)
		{
			return "SELECT date_time as fecha, date_time as hora, username, item, sales.quantity, sales.price FROM sales, products, users WHERE user=user_id AND product = product_id AND " + "fecha >= '" + initDate + "' AND fecha <= '" + endDate + "'";
		}

		public static string GetIncomes(string initDate, string endDate)
		{
			return "SELECT date_time as fecha, date_time as hora, username, item, incomes.quantity, incomes.price FROM incomes, products, users WHERE user=user_id AND product = product_id AND " + "fecha >= '" + initDate + "' AND fecha <= '" + endDate + "'";
		}

		public static string UserExist(string username)
		{
			return "SELECT COUNT(username) FROM users WHERE username = '" + username + "'";
		}

		#endregion

		public static string FILL_TEST_DATA = "INSERT INTO types VALUES(NULL, 'Refrescos');INSERT INTO types VALUES(NULL, 'Salchichoneria');INSERT INTO products VALUES (NULL,'Coca Cola 10 ml', 'pieza',1,5,10,10,8,1);INSERT INTO products VALUES (NULL,'Rajas 10 gr', 'pieza',1,5,10,5.5,3.5,1);";

	}
}
