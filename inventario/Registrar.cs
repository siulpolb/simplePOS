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
	public partial class Registrar : Form
	{
		DB db;
		User user;
		//Dictionary<int, string> types;
		public Registrar(DB db, User user)
		{
			InitializeComponent();
			this.db = db;
			this.user = user;
			var types = db.getTypes();
			types.Add(new Type { Name = "Otro", Id = -1});
			cbType.DataSource = types;
			cbType.DisplayMember = "Name";
			cbType.ValueMember = "Id";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = "";
			string unit = "";
			double minimum = 0;
			double sell = 0;
			double buy = 0;
			int type = -1;
			Console.WriteLine("Valor: " + cbType.SelectedValue);
			Console.WriteLine("Texto: " + cbType.Text);
			if(tbName.Text != "")
			{
				name = tbName.Text;
				if (tbUnit.Text != "")
				{
					unit = tbUnit.Text;
					if (double.TryParse(tbMinimum.Text, out minimum))
					{
						if (double.TryParse(tbSellPrice.Text, out sell))
						{
							if (double.TryParse(tbBuyPrice.Text, out buy))
							{
								type = Convert.ToInt32(cbType.SelectedValue);
								if (type == -1)
								{
									InputMessage m = new InputMessage("Nuevo Tipo", "Introduzca el nuevo tipo de producto");
									m.ShowDialog();
									type = db.newType(m.Message);
								}
								db.newProduct(name, unit, minimum, type, sell, buy);
								MessageBox.Show("Producto Agregado");
								this.Close();
							}
							else
							{
								tbBuyPrice.Text = "";
								tbBuyPrice.Focus();
							}
						}
						else
						{
							tbSellPrice.Text = "";
							tbSellPrice.Focus();
						}
					}
					else
					{
						tbMinimum.Text = "";
						tbMinimum.Focus();
					}
				}
				else
				{
					tbUnit.Focus();
				}
			}
			else
			{
				tbName.Focus();
			}
			
		}
	}
}
