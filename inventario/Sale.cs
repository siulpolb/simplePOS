using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
	public class Sale
	{
		public string Fecha { get; set; }
		public string Hora { get; set; }
		public string Product { get; set; }
		public string User { get; set; }
		public double Quantity { get; set; }
		public double Price { get; set; }

		public Sale()
		{

		}

		public Sale(string fecha, string hora, string product, string user, double quantity, double price)
		{
			Fecha = fecha;
			Hora = hora;
			Product = product;
			User = user;
			Quantity = quantity;
			Price = price;
		}

		public double getTotal()
		{
			return Quantity * Price;
		}

		public object[] ToObjectArray()
		{
			object[] o = new object[6];
			o[0] = Fecha;
			o[1] = Hora;
			o[2] = User;
			o[3] = Product;
			o[4] = Quantity;
			o[5] = Price;
			return o;
		}
	}
}
