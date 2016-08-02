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
	public partial class Login : Form
	{

		public User User;
		private DB db;

		public Login(DB db)
		{
			InitializeComponent();
			this.db = db;
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (!isValid())
				return;
			User = db.login(tbUser.Text,tbPassword.Text);
			if (User.UserId != -1)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
				MessageBox.Show("Usuario o Contraseña Incorrectos");
		}

		private bool isValid()
		{
			bool valid = false;
			if (tbUser.Text == "")
				tbUser.Focus();
			else if (tbPassword.Text == "")
				tbPassword.Focus();
			else
				valid = true;
			return valid;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void tbPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin.PerformClick();
			}
		}
	}
}
