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
			cbType.DataSource = types;
			cbType.DisplayMember = "Name";
			cbType.ValueMember = "Id";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			
		}

		private void cbType_SelectedValueChanged(object sender, EventArgs e)
		{
			Console.WriteLine("Valor: " + cbType.SelectedValue);
			Console.WriteLine("Texto: " + cbType.SelectedText);
			Console.WriteLine(cbType.SelectedItem);
		}
	}
}
