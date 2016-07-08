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
		private Dictionary<int, int> sell;
		private double sellTotal;
		private Dictionary<int, Product> prueba;

		public Form1()
		{
			InitializeComponent();
			db = new DB();
			productNames = new Dictionary<string, int>();
			products = new List<Product>();
			sell = new Dictionary<int, int>();
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
			if(productNames.TryGetValue(tbProductName.Text,out id))
			{
				Product product = null;
				foreach (Product p in products)
					if (p.Id == id)
					{
						product = p;
						break;
					}
				if (sell.ContainsKey(product.Id))
				{
					sell[product.Id] += 1;
					for(int i = 0; i < dgvSell.Rows.Count; i++)
					{
						if (Convert.ToInt32(dgvSell.Rows[i].Cells[0].Value) == product.Id)
						{
							dgvSell.Rows[i].Cells[3].Value = sell[product.Id];

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
					values[3] = 1; //cantidad
					values[4] = product.Price;
					values[5] = product.Price;
					values[6] = "";
					dgvSell.Rows.Add(values);
				}
			}
			tbProductName.Text = "";
		}
	}
}
