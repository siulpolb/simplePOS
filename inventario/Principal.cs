﻿using System;
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
	public partial class Principal : Form
	{
		DB db;
		User user;


		public Principal()
		{
			InitializeComponent();
			db = new DB();
			login();
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

		private void checkPermissions()
		{
			if ((user.UserLevel & 1) != 1)
				btnVentas.Enabled = false;
			if ((user.UserLevel & 2) != 2)
				btnEntradas.Enabled = false;
			if ((user.UserLevel & 4) != 4)
				btnInventario.Enabled = false;
			if ((user.UserLevel & 8) != 8)
				btnReportes.Enabled = false;
			if ((user.UserLevel & 16) != 16)
				btnIncidentes.Enabled = false;
			if ((user.UserLevel & 32) != 32)
				btnUsuarios.Enabled = false;
			if ((user.UserLevel & 64) != 64)
				btnNuevoProducto.Enabled = false;
			if ((user.UserLevel & 128) != 128)
				button7.Enabled = false;
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			this.Hide();
			Ventas ventas = new Ventas(db, user);
			ventas.ShowDialog();
			this.Show();
		}

		private void btnEntradas_Click(object sender, EventArgs e)
		{
			this.Hide();
			Entradas entrada = new Entradas(db, user);
			entrada.ShowDialog();
			this.Show();
		}

		private void btnInventario_Click(object sender, EventArgs e)
		{
			this.Hide();
			List list = new List(db);
			list.ShowDialog();
			this.Show();
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{

		}

		private void btnIncidentes_Click(object sender, EventArgs e)
		{

		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			Registrar registrar = new Registrar(db, user);
			registrar.ShowDialog();
			this.Show();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}