using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Type { get; set; }
        public int MinimumStock { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, string unit, string type, int minimum, int stock, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Unit = unit;
            this.Type = type;
            this.MinimumStock = minimum;
            this.Stock = stock;
            this.Price = price;
        }

		public object[] toObjectArray()
		{
			object[] values = new object[7];
			values[0] = Id;
			values[1] = Name;
			values[2] = Unit;
			values[3] = Type;
			values[4] = MinimumStock;
			values[5] = Stock;
			values[6] = Price;
			return values;
		}
    }
}
