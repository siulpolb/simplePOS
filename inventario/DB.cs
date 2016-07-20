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

		public int[] login(string user, string password)
		{
			string query;
			int[] userData = new int[2];
			userData[0] = -1;
			userData[1] = -1;
			SQLiteCommand command;
			connection.Open();
			query = Query.Login(user,password);
			command = new SQLiteCommand(query, connection);
			SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				userData[0] = Convert.ToInt32(reader["user_id"]);
				userData[1] = Convert.ToInt32(reader["level"]);
			}
			reader.Close();
			connection.Close();
			return userData;
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


	}
}
