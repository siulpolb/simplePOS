﻿using System;
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
			query = Query.CREATE_TABLE_SALES;
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			query = Query.CREATE_TABLE_INCOMES;
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			query = Query.CREATE_TABLE_LOG;
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			try
			{
				query = Query.INSERT_SUPER_USER;
				command = new SQLiteCommand(query, connection);
				command.ExecuteNonQuery();
			}
			catch (SQLiteException) { }
			/*query = Query.FILL_TEST_DATA;
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();*/
			connection.Close();
		}

		public User login(string user, string password)
		{
			string query;
			User loguedUser = new User(-1, user, -1);
			SQLiteCommand command;
			connection.Open();
			query = Query.Login(user,password);
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				loguedUser.UserId = Convert.ToInt32(reader["user_id"]);
				loguedUser.UserLevel = Convert.ToInt32(reader["level"]);
			}
			reader.Close();
			connection.Close();
			return loguedUser;
		}

		public List<Product> getAllProducts()
		{
			List<Product> products = new List<Product>();
			string query;
			SQLiteCommand command;
			connection.Open();
			query = Query.GET_ALL_PRODUCTS;
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
					Product newProduct = new Product(
						Convert.ToInt32(reader["product_id"]),
						(string)reader["item"],
						(string)reader["unit"],
						(string)reader["type"],
						Convert.ToInt32(reader["minimum_stock"]),
						Convert.ToInt32(reader["current_stock"]),
						(double)reader["price"],
						(double)reader["buy_price"]
						);
					products.Add(newProduct);
			}
			reader.Close();
			connection.Close();
			return products;
		}

		public void sell(int[] product, double[] quantity, int user, double[] price)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			for (int i = 0; i < product.Length; i++)
			{
				query = Query.Sell(product[i], quantity[i], user, price[i]);
				command = new SQLiteCommand(query, connection);
				command.ExecuteNonQuery();
				query = Query.UpdateStock(product[i], quantity[i],false);
				command = new SQLiteCommand(query, connection);
				command.ExecuteNonQuery();
			}
			transaction.Commit();
			connection.Close();
		}

		public void buy(int[] product, double[] quantity, int user, double[] price)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			for (int i = 0; i < product.Length; i++)
			{
				query = Query.Buy(product[i], quantity[i], user, price[i]);
				command = new SQLiteCommand(query, connection);
				command.ExecuteNonQuery();
				query = Query.UpdateStock(product[i], quantity[i], true);
				command = new SQLiteCommand(query, connection);
				command.ExecuteNonQuery();
			}
			transaction.Commit();
			connection.Close();
		}

		public void updatePrice(int product, double newPrice)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.UpdatePrice(product, newPrice);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public void updateBuyPrice(int product, double newPrice)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.UpdateBuyPrice(product, newPrice);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public List<Type> getTypes()
		{
			List<Type> types = new List<Type>();
			string query = Query.GET_TYPES;
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				types.Add(new Type() { Id = Convert.ToInt32(reader["type_id"]), Name = Convert.ToString(reader["name"]) });
			}
			reader.Close();
			connection.Close();
			return types;
		}

		public void newProduct(string name, string unit, double minimum, int type, double sellPrice, double buyPrice)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.NewProduct(name,unit,minimum,type,sellPrice,buyPrice);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public int newType(string name)
		{
			string query;
			int newType = -1;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.NewType(name);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			query = Query.GetTypeByName(name);
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
				newType = Convert.ToInt32(reader["type_id"]);
			reader.Close();
			transaction.Commit();
			connection.Close();
			return newType;
		}

		public void newLog(int user, string text)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.NewLog(user,text);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public List<Log> getAllLogs()
		{
			List<Log> logs = new List<Log>();
			string query = Query.GET_ALL_LOGS;
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				logs.Add(new Log() {
					User = reader["username"].ToString(),
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					Text = reader["log"].ToString()
				});
			}
			reader.Close();
			connection.Close();
			return logs;
		}

		public List<Log> getLogsDates(DateTime from, DateTime to)
		{
			List<Log> logs = new List<Log>();
			string initDate = ToUnixTime(from).ToString();
			string endDate = ToUnixTime(to).ToString();
			string query = Query.GetLogs(initDate, endDate);
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				logs.Add(new Log()
				{
					User = reader["username"].ToString(),
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					Text = reader["log"].ToString()
				});
			}
			reader.Close();
			connection.Close();
			return logs;
		}

		public List<User> getAllUsers()
		{
			List<User> users = new List<User>();
			string query = Query.GET_ALL_USERS;
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				users.Add(new User()
				{
					Username = reader["username"].ToString(),
					UserId = Convert.ToInt32(reader["user_id"]),
					UserLevel = Convert.ToInt32(reader["level"])
				});
			}
			reader.Close();
			connection.Close();
			return users;
		}

		public bool userExist(string username)
		{
			bool exists = false;
			int count = 0;
			string query = Query.UserExist(username);
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				count = reader.GetInt32(0);
			}
			reader.Close();
			connection.Close();
			if (count > 0)
				exists = true;
			return exists;
		}

		public void updateUser(int user, string password, int level, int active)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.UpdateUser(user, password, level, active);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public void newUser(string username, string password, int level)
		{
			string query;
			SQLiteCommand command;
			connection.Open();
			SQLiteTransaction transaction = connection.BeginTransaction();
			query = Query.NewUser(username, password, level);
			command = new SQLiteCommand(query, connection);
			command.ExecuteNonQuery();
			transaction.Commit();
			connection.Close();
		}

		public List<Sale> getAllSales()
		{
			List<Sale> sales = new List<Sale>();
			string query = Query.GET_ALL_SALES;
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				sales.Add(new Sale()
				{
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					User = reader.GetString(2),
					Product = reader.GetString(3),
					Quantity = reader.GetDouble(4),
					Price = reader.GetDouble(5)
				});
			}
			reader.Close();
			connection.Close();
			return sales;
		}

		public List<Sale> getAllIncomes()
		{
			List<Sale> incomes = new List<Sale>();
			string query = Query.GET_ALL_INCOMES;
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				incomes.Add(new Sale()
				{
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					User = reader.GetString(2),
					Product = reader.GetString(3),
					Quantity = reader.GetDouble(4),
					Price = reader.GetDouble(5)
				});
			}
			reader.Close();
			connection.Close();
			return incomes;
		}

		public List<Sale> getSales(DateTime initDate, DateTime endDate)
		{
			List<Sale> sales = new List<Sale>();
			string from = ToUnixTime(initDate).ToString();
			string to = ToUnixTime(endDate).ToString();
			string query = Query.GetSales(from, to);
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				sales.Add(new Sale()
				{
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					User = reader.GetString(2),
					Product = reader.GetString(3),
					Quantity = reader.GetDouble(4),
					Price = reader.GetDouble(5)
				});
			}
			reader.Close();
			connection.Close();
			return sales;
		}

		public List<Sale> getIncomes(DateTime initDate, DateTime endDate)
		{
			List<Sale> incomes = new List<Sale>();
			string from = ToUnixTime(initDate).ToString();
			string to = ToUnixTime(endDate).ToString();
			string query = Query.GetIncomes(from, to);
			SQLiteCommand command;
			connection.Open();
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				incomes.Add(new Sale()
				{
					Fecha = FromUnixTime(reader.GetInt64(0)).ToShortDateString(),
					Hora = FromUnixTime(reader.GetInt64(1)).ToLongTimeString(),
					User = reader.GetString(2),
					Product = reader.GetString(3),
					Quantity = reader.GetDouble(4),
					Price = reader.GetDouble(5)
				});
			}
			reader.Close();
			connection.Close();
			return incomes;
		}

		public DateTime FromUnixTime(long unixTime)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return epoch.AddSeconds(unixTime).ToLocalTime();
		}

		public long ToUnixTime(DateTime date)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalSeconds);
		}
	}
}
