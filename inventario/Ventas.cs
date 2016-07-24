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
	public partial class Ventas : Form
	{
		private DB db;
		private User user;
		private Dictionary<string, int> productNames;
		private List<Product> products;
		private Dictionary<int, double> sell;//id,cantidad
		private double sellTotal;

		public Ventas()
		{
			InitializeComponent();
			db = new DB();
			productNames = new Dictionary<string, int>();
			products = new List<Product>();
			sell = new Dictionary<int, double>();
			sellTotal = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//login();
			Registrar r = new Registrar(db,user);
			r.ShowDialog();
			loadProducts();
			loadAutocomplete();
			checkPermissions();
		}

		private void login()
		{
			Login login = new Login(db);
			var result = login.ShowDialog();
			if (login.DialogResult != DialogResult.OK)
				this.Close();
			user = login.User;
		}

		private void loadAutocomplete()
		{
			var source = new AutoCompleteStringCollection();
			source.AddRange(productNames.Keys.ToArray());
			tbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			tbProductName.AutoCompleteCustomSource = source;
			tbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		}

		private void loadProducts()
		{
			productNames.Clear();
			products.Clear();
			products = db.getAllProducts();
			foreach(Product product in products)
				productNames.Add(product.Name, product.Id);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int id;
			if (tbProductName.Text == "")
				return;
			if(productNames.TryGetValue(tbProductName.Text,out id))//si el producto existe
			{
				Product product = getProductById(id);
				if (product.Stock > 0)
				{
					if (sell.ContainsKey(product.Id))//si ya esta en el carrito
					{
						sell[product.Id] += 1;
						for (int i = 0; i < dgvSell.Rows.Count; i++)
						{
							if (Convert.ToInt32(dgvSell.Rows[i].Cells[0].Value) == product.Id)
							{
								dgvSell.Rows[i].Cells[3].Value = sell[product.Id];
								dgvSell.Rows[i].Cells[5].Value = sell[product.Id] * product.Price;
							}
						}
					}
					else
					{
						sell.Add(product.Id, 1);
						object[] values = new object[6];
						values[0] = product.Id;
						values[1] = product.Name;
						values[2] = product.Unit;
						values[3] = 1.0; //cantidad
						values[4] = product.Price;
						values[5] = product.Price;//Total
						dgvSell.Rows.Add(values);
					}
					updateTotal(product.Price, true);
				}
				else
					MessageBox.Show("Producto sin Existencias");
			}
			tbProductName.Text = "";
		}

		private void updateTotal(double amount, bool increase)
		{
			if (increase)
				sellTotal += amount;
			else
				sellTotal -= amount;
			lbTotal.Text = "Total: $" + sellTotal.ToString();
		}

		private void dgvSell_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 3)
			{
				double quantity = 0;
				int product_id = (int)dgvSell.Rows[e.RowIndex].Cells[0].Value;
				try
				{
					quantity = Convert.ToDouble(dgvSell.Rows[e.RowIndex].Cells[3].Value);
				}
				catch(Exception)
				{
					dgvSell.Rows[e.RowIndex].Cells[3].Value = sell[product_id];//si no es un numero
					return;
				}
				Product p = getProductById(product_id);
				if (quantity > p.Stock)
				{
					quantity = p.Stock;
					dgvSell.Rows[e.RowIndex].Cells[3].Value = quantity;
				}
				dgvSell.Rows[e.RowIndex].Cells[5].Value = sell[p.Id] * p.Price;
				updateTotal(p.Price * sell[product_id], false);
				if (quantity <= 0)
				{
					sell.Remove(product_id);
					dgvSell.Rows.RemoveAt(e.RowIndex);
				}
				else
				{
					sell[product_id] = quantity;
					updateTotal(p.Price * sell[product_id], true);
					dgvSell.Rows[e.RowIndex].Cells[5].Value = sell[p.Id] * p.Price;
				}
			}
		}

		private void tbProductName_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnAdd.PerformClick();
			}
		}

		private Product getProductById(int id)
		{
			Product product = null;
			foreach (Product p in products)
				if (p.Id == id)
				{
					product = p;
					break;
				}
			return product;
		}

		private void btnSell_Click(object sender, EventArgs e)
		{
			int[] ids = new int[sell.Keys.Count];
			double[] quantitys = new double[sell.Keys.Count];
			double[] prices = new double[sell.Keys.Count];
			int i = 0;
			foreach (KeyValuePair<int, double> p in sell)
			{
				ids[i] = p.Key;
				quantitys[i] = p.Value;
				Product prod = getProductById(p.Key);
				prices[i] = prod.Price;
				i++;
			}
			db.sell(ids,quantitys,user.UserId,prices);
			sell.Clear();
			dgvSell.Rows.Clear();
			loadProducts();
			loadAutocomplete();
			lbTotal.Text = "Total: $0";
			sellTotal = 0;
			MessageBox.Show("Venta Exitosa");
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void checkPermissions()
		{
			if(user.UserLevel != 0)
			{
				tsmiAdmin.Enabled = false;
			}
		}

		private void dgvSell_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			int product_id = (int)e.Row.Cells[0].Value;
			Product p = getProductById(product_id);
			updateTotal(p.Price * sell[product_id], false);
			sell.Remove(product_id);
		}

		private void tsmiList_Click(object sender, EventArgs e)
		{
			List list = new List(db);
			list.ShowDialog();
		}

		private void tsmiIncomings_Click(object sender, EventArgs e)
		{
			Entradas entrada = new Entradas(db,user);
			entrada.ShowDialog();
			loadProducts();
			loadAutocomplete();
		}
	}
}
