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
	public partial class NewUsers : Form
	{
		DB db;
		List<User> users;
		public NewUsers(DB db)
		{
			InitializeComponent();
			this.db = db;
			users = db.getAllUsers();
			fillData();
		}

		public void fillData()
		{
			dgvUsers.Rows.Clear();
			foreach(User u in users)
			{
				object[] o = new object[3];
				o[0] = u.Username;
				o[1] = "Editar";
				o[2] = "Eliminar";
				dgvUsers.Rows.Add(o);
			}
		}

		public User findUserByUsername(string username)
		{
			User user = null;
			foreach(User u in users)
			{
				if(u.Username == username)
				{
					user = u;
				}
			}
			return user;
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 1)
			{
				User user = findUserByUsername(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
				tbUser.Text = user.Username;
				setCheckedPermissions(user.UserLevel);

			}
			if(e.ColumnIndex == 2)
			{
				User user = findUserByUsername(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
				db.updateUser(user.UserId, "", 0, 0);
				MessageBox.Show("Usuario eliminado con exito");
			}
			users = db.getAllUsers();
			fillData();
		}

		public void setCheckedPermissions(int level)
		{
			clearCLB();
			if ((level & 1) == 1)
				clbPermissions.SetItemChecked(0,true);
			if ((level & 2) == 2)
				clbPermissions.SetItemChecked(1, true);
			if ((level & 4) == 4)
				clbPermissions.SetItemChecked(2, true);
			if ((level & 8) == 8)
				clbPermissions.SetItemChecked(3, true);
			if ((level & 16) == 16)
				clbPermissions.SetItemChecked(4, true);
			if ((level & 32) == 32)
				clbPermissions.SetItemChecked(5, true);
			if ((level & 128) == 128)
				clbPermissions.SetItemChecked(6, true);
			if ((level & 64) == 64)
				clbPermissions.SetItemChecked(7, true);

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			User user = findUserByUsername(tbUser.Text);
			if(user != null)
			{
				db.updateUser(user.UserId, tbPassword.Text, getCheckedPermissions(), 1);
				MessageBox.Show("Usuario actualizado con exito");
			}
			else
			{
				MessageBox.Show("El usuario NO existe");
			}
			tbUser.Clear();
			tbPassword.Clear();
			clearCLB();
			users = db.getAllUsers();
			fillData();
		}

		public int getCheckedPermissions()
		{
			int permissions = 0;
			if (clbPermissions.GetItemChecked(0))
				permissions |= 1;
			if (clbPermissions.GetItemChecked(1))
				permissions |= 2;
			if (clbPermissions.GetItemChecked(2))
				permissions |= 4;
			if (clbPermissions.GetItemChecked(3))
				permissions |= 8;
			if (clbPermissions.GetItemChecked(4))
				permissions |= 16;
			if (clbPermissions.GetItemChecked(5))
				permissions |= 32;
			if (clbPermissions.GetItemChecked(6))
				permissions |= 128;
			if (clbPermissions.GetItemChecked(7))
				permissions |= 64;
			return permissions;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			if(tbUser.Text != "" && tbPassword.Text != "")
			{
				User user = findUserByUsername(tbUser.Text);
				if (user == null && !db.userExist(tbUser.Text))
				{
					db.newUser(tbUser.Text, tbPassword.Text, getCheckedPermissions());
					MessageBox.Show("Usuario creado con exito");
				}
				else
				{
					MessageBox.Show("El usuario YA existe");
				}
				tbUser.Clear();
				tbPassword.Clear();
				clearCLB();
				users = db.getAllUsers();
				fillData();
			}
			else
			{
				MessageBox.Show("Faltan Datos");
				tbUser.Focus();
			}
		}

		private void clearCLB()
		{
			clbPermissions.ClearSelected();
			for(int i = 0; i < clbPermissions.Items.Count; i ++)
				clbPermissions.SetItemChecked(i, false);
		}
	}
}
