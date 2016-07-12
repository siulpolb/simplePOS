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
	public partial class Form1 : Form
	{
		private DB db;
		private string username;
		private int userId;
		private int userLevel;
		private Dictionary<string, int> productNames;
		private List<Product> products;
		private Dictionary<int, double> sell;//id,cantidad
		private double sellTotal;

		public Form1()
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
            loadProducts();
            loadAutocomplete();
        }

        private void login()
        {
            Login login = new Login(db);
            var result = login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
                this.Close();
            username = login.Username;
            userId = login.UserId;
            userLevel = login.UserLevel;
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
				if (sell.ContainsKey(product.Id))//si ya esta en el carrito
				{
					sell[product.Id] += 1;
					for(int i = 0; i < dgvSell.Rows.Count; i++)
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
					object[] values = new object[7];
					values[0] = product.Id;
					values[1] = product.Name;
					values[2] = product.Unit;
					values[3] = 1.0; //cantidad
					values[4] = product.Price;
					values[5] = product.Price;//Total
					values[6] = "";
					dgvSell.Rows.Add(values);
				}
				updateTotal(product.Price, true);
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
				int product_id = (int)dgvSell.Rows[e.RowIndex].Cells[0].Value;
				double quantity = Convert.ToDouble(dgvSell.Rows[e.RowIndex].Cells[3].Value);
				Product p = getProductById(product_id);
				if (quantity > p.Stock)
				{
					quantity = p.Stock;
					dgvSell.Rows[e.RowIndex].Cells[3].Value = quantity;
				}
				dgvSell.Rows[e.RowIndex].Cells[5].Value = sell[p.Id] * p.Price;
				updateTotal(p.Price * sell[product_id], false);
				if (quantity < 1)
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
			Query.Sell(1, 1,"siulpolb",10);
		}
	}
}
