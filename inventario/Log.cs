using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
	public class Log
	{
		public string User { get; set; }
		public string Fecha { get; set; }
		public string Hora { get; set; }
		public string Text { get; set; }

		public object[] toObjectArray()
		{
			object[] array = new object[4];
			array[0] = this.Fecha;
			array[1] = this.Hora;
			array[2] = this.User;
			array[3] = this.Text;
			return array;
		}
	}
}
