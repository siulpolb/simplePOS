namespace inventario
{
	partial class Principal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnVentas = new System.Windows.Forms.Button();
			this.btnEntradas = new System.Windows.Forms.Button();
			this.btnInventario = new System.Windows.Forms.Button();
			this.btnReportes = new System.Windows.Forms.Button();
			this.btnIncidentes = new System.Windows.Forms.Button();
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.btnReportarIncidente = new System.Windows.Forms.Button();
			this.btnNuevoProducto = new System.Windows.Forms.Button();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVentas
			// 
			this.btnVentas.Location = new System.Drawing.Point(12, 12);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(110, 82);
			this.btnVentas.TabIndex = 0;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.UseVisualStyleBackColor = true;
			this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
			// 
			// btnEntradas
			// 
			this.btnEntradas.Location = new System.Drawing.Point(208, 12);
			this.btnEntradas.Name = "btnEntradas";
			this.btnEntradas.Size = new System.Drawing.Size(110, 82);
			this.btnEntradas.TabIndex = 1;
			this.btnEntradas.Text = "Entradas";
			this.btnEntradas.UseVisualStyleBackColor = true;
			this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
			// 
			// btnInventario
			// 
			this.btnInventario.Location = new System.Drawing.Point(396, 12);
			this.btnInventario.Name = "btnInventario";
			this.btnInventario.Size = new System.Drawing.Size(110, 82);
			this.btnInventario.TabIndex = 2;
			this.btnInventario.Text = "Inventario";
			this.btnInventario.UseVisualStyleBackColor = true;
			this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
			// 
			// btnReportes
			// 
			this.btnReportes.Location = new System.Drawing.Point(12, 143);
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Size = new System.Drawing.Size(110, 82);
			this.btnReportes.TabIndex = 3;
			this.btnReportes.Text = "Reportes";
			this.btnReportes.UseVisualStyleBackColor = true;
			this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
			// 
			// btnIncidentes
			// 
			this.btnIncidentes.Location = new System.Drawing.Point(208, 143);
			this.btnIncidentes.Name = "btnIncidentes";
			this.btnIncidentes.Size = new System.Drawing.Size(110, 82);
			this.btnIncidentes.TabIndex = 4;
			this.btnIncidentes.Text = "Incidentes";
			this.btnIncidentes.UseVisualStyleBackColor = true;
			this.btnIncidentes.Click += new System.EventHandler(this.btnIncidentes_Click);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.Location = new System.Drawing.Point(396, 143);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(110, 82);
			this.btnUsuarios.TabIndex = 5;
			this.btnUsuarios.Text = "Usuarios";
			this.btnUsuarios.UseVisualStyleBackColor = true;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// btnReportarIncidente
			// 
			this.btnReportarIncidente.Location = new System.Drawing.Point(12, 273);
			this.btnReportarIncidente.Name = "btnReportarIncidente";
			this.btnReportarIncidente.Size = new System.Drawing.Size(110, 82);
			this.btnReportarIncidente.TabIndex = 6;
			this.btnReportarIncidente.Text = "Reportar Incidente";
			this.btnReportarIncidente.UseVisualStyleBackColor = true;
			this.btnReportarIncidente.Click += new System.EventHandler(this.button7_Click);
			// 
			// btnNuevoProducto
			// 
			this.btnNuevoProducto.Location = new System.Drawing.Point(208, 273);
			this.btnNuevoProducto.Name = "btnNuevoProducto";
			this.btnNuevoProducto.Size = new System.Drawing.Size(110, 82);
			this.btnNuevoProducto.TabIndex = 7;
			this.btnNuevoProducto.Text = "Nuevo Producto";
			this.btnNuevoProducto.UseVisualStyleBackColor = true;
			this.btnNuevoProducto.Click += new System.EventHandler(this.button8_Click);
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Location = new System.Drawing.Point(396, 273);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(110, 82);
			this.btnCerrarSesion.TabIndex = 8;
			this.btnCerrarSesion.Text = "Cerrar Sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = true;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 367);
			this.Controls.Add(this.btnCerrarSesion);
			this.Controls.Add(this.btnNuevoProducto);
			this.Controls.Add(this.btnReportarIncidente);
			this.Controls.Add(this.btnUsuarios);
			this.Controls.Add(this.btnIncidentes);
			this.Controls.Add(this.btnReportes);
			this.Controls.Add(this.btnInventario);
			this.Controls.Add(this.btnEntradas);
			this.Controls.Add(this.btnVentas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnVentas;
		private System.Windows.Forms.Button btnEntradas;
		private System.Windows.Forms.Button btnInventario;
		private System.Windows.Forms.Button btnReportes;
		private System.Windows.Forms.Button btnIncidentes;
		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.Button btnReportarIncidente;
		private System.Windows.Forms.Button btnNuevoProducto;
		private System.Windows.Forms.Button btnCerrarSesion;
	}
}