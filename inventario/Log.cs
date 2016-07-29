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
		public DateTime Fecha { get; set; }
		public DateTime Hora { get; set; }
		public string Text { get; set; }

		public object[] toObjectArray()
		{
			object[] array = new object[4];
			array[0] = this.User;
			//array[1] = this.Fecha;
			//array[2] = this.Hora;
			array[1] = this.Fecha.ToShortDateString();
			array[2] = this.Hora.ToLongTimeString();
			array[3] = this.Text;
			return array;
		}
	}
}
