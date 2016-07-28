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
	public partial class Entradas : Form
	{
		private User user;
		private DB db;
		private Dictionary<string, int> productNames;
		private List<Product> products;
		private Dictionary<int, double> buy;//id,cantidad
		private double buyTotal;

		public Entradas(DB db, User user)
		{
			InitializeComponent();
			this.user = user;
			this.db = db;
			productNames = new Dictionary<string, int>();
			products = new List<Product>();
			buy = new Dictionary<int, double>();
			buyTotal = 0;
		}

		private void Entradas_Load(object sender, EventArgs e)
		{
			loadProducts();
			loadAutocomplete();
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
				if (buy.ContainsKey(product.Id))//si ya esta en el carrito
				{
					buy[product.Id] += 1;
					for (int i = 0; i < dgvBuy.Rows.Count; i++)
					{
						if (Convert.ToInt32(dgvBuy.Rows[i].Cells[0].Value) == product.Id)
						{
							dgvBuy.Rows[i].Cells[3].Value = buy[product.Id];
							dgvBuy.Rows[i].Cells[5].Value = buy[product.Id] * product.BuyPrice;
						}
					}
				}
				else
				{
					buy.Add(product.Id, 1);
					object[] values = new object[6];
					values[0] = product.Id;
					values[1] = product.Name;
					values[2] = product.Unit;
					values[3] = 1.0; //cantidad
					values[4] = product.BuyPrice;
					values[5] = product.BuyPrice;//Total
					dgvBuy.Rows.Add(values);
				}
				updateTotal(product.BuyPrice, true);
			}
			tbProductName.Text = "";
		}

		private void updateTotal(double amount, bool increase)
		{
			if (increase)
				buyTotal += amount;
			else
				buyTotal -= amount;
			lbTotal.Text = "Total: $" + buyTotal.ToString();
		}

		private void dgvSell_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 3)
			{
				double quantity = 0;
				int product_id = (int)dgvBuy.Rows[e.RowIndex].Cells[0].Value;
				try
				{
					quantity = Convert.ToDouble(dgvBuy.Rows[e.RowIndex].Cells[3].Value);
				}
				catch(Exception)
				{
					dgvBuy.Rows[e.RowIndex].Cells[3].Value = buy[product_id];//si no es un numero
					return;
				}
				Product p = getProductById(product_id);
				dgvBuy.Rows[e.RowIndex].Cells[5].Value = buy[p.Id] * p.BuyPrice;
				updateTotal(p.BuyPrice * buy[product_id], false);
				if (quantity <= 0)
				{
					buy.Remove(product_id);
					dgvBuy.Rows.RemoveAt(e.RowIndex);
				}
				else
				{
					buy[product_id] = quantity;
					updateTotal(p.BuyPrice * buy[product_id], true);
					dgvBuy.Rows[e.RowIndex].Cells[5].Value = buy[p.Id] * p.BuyPrice;
				}
			}

			if (e.ColumnIndex == 4)
			{
				InputMessage m = new InputMessage("Motivo", "Describa el motivo del cambio de precio");
				m.ShowDialog();
				string log = "Cambio de precio de " + dgvBuy.Rows[e.RowIndex].Cells[1].Value.ToString() + " Motivo: " + m.Message;
				db.newLog(user.UserId, log);
				int product_id = (int)dgvBuy.Rows[e.RowIndex].Cells[0].Value;
				double newPrice = 0;
				Product p = getProductById(product_id);
				try
				{
					newPrice = Convert.ToDouble(dgvBuy.Rows[e.RowIndex].Cells[4].Value);
				}
				catch (Exception)
				{
					dgvBuy.Rows[e.RowIndex].Cells[4].Value = p.BuyPrice;//si no es un numero
					return;
				}
				updateTotal(p.BuyPrice * buy[product_id], false);
				p.BuyPrice = newPrice;
				dgvBuy.Rows[e.RowIndex].Cells[5].Value = buy[p.Id] * p.BuyPrice;
				updateTotal(p.BuyPrice * buy[product_id], true);
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

		private void dgvSell_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			int product_id = (int)e.Row.Cells[0].Value;
			Product p = getProductById(product_id);
			updateTotal(p.BuyPrice * buy[product_id], false);
			buy.Remove(product_id);
		}

		private void tsmiList_Click(object sender, EventArgs e)
		{
			List list = new List(db);
			list.ShowDialog();
		}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			int[] ids = new int[buy.Keys.Count];
			double[] quantitys = new double[buy.Keys.Count];
			double[] prices = new double[buy.Keys.Count];
			int i = 0;
			foreach (KeyValuePair<int, double> p in buy)
			{
				ids[i] = p.Key;
				quantitys[i] = p.Value;
				Product prod = getProductById(p.Key);
				prices[i] = prod.BuyPrice;
				db.updateBuyPrice(ids[i], prices[i]);
				i++;
			}
			db.buy(ids, quantitys, user.UserId, prices);
			buy.Clear();
			dgvBuy.Rows.Clear();
			loadProducts();
			loadAutocomplete();
			lbTotal.Text = "Total: $0";
			buyTotal = 0;
			MessageBox.Show("Compra Exitosa");
		}
	}
}
