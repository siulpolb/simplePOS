using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
	public partial class List : Form
	{
		DB db;
		List<Product> products;
		public List(DB db)
		{
			InitializeComponent();
			this.db = db;
			products = db.getAllProducts();
			foreach(Product p in products)
			{
				dgvList.Rows.Add(p.toObjectArray());
				//if(p.Stock < 1)
					
			}
		}
	}
}
