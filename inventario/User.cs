using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
	public class User
	{
		public string Username { get; set; }
		public int UserId { get; set; }
		public int UserLevel { get; set; }

		public User(int userId, string username, int level)
		{
			this.UserId = userId;
			this.Username = username;
			this.UserLevel = level;
		}
	}
}
