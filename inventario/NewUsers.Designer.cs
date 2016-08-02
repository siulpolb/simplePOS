namespace inventario
{
	partial class NewUsers
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.clbPermissions = new System.Windows.Forms.CheckedListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre de Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña:";
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(119, 12);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(158, 20);
			this.tbUser.TabIndex = 2;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(119, 42);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(158, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// clbPermissions
			// 
			this.clbPermissions.CheckOnClick = true;
			this.clbPermissions.FormattingEnabled = true;
			this.clbPermissions.Items.AddRange(new object[] {
            "Venta",
            "Entrada",
            "Inventario",
            "Reportes",
            "Incidentes",
            "Usuarios",
            "Reportar Incidentes",
            "Nuevo Producto"});
			this.clbPermissions.Location = new System.Drawing.Point(326, 42);
			this.clbPermissions.MultiColumn = true;
			this.clbPermissions.Name = "clbPermissions";
			this.clbPermissions.Size = new System.Drawing.Size(252, 64);
			this.clbPermissions.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(323, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Permisos:";
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(52, 83);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 6;
			this.btnNew.Text = "Nuevo";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(202, 83);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Actualizar";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUsername,
            this.clmEdit,
            this.clmDelete});
			this.dgvUsers.Location = new System.Drawing.Point(12, 135);
			this.dgvUsers.MultiSelect = false;
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.Size = new System.Drawing.Size(617, 150);
			this.dgvUsers.TabIndex = 8;
			this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
			// 
			// clmUsername
			// 
			this.clmUsername.HeaderText = "Usuario";
			this.clmUsername.Name = "clmUsername";
			this.clmUsername.ReadOnly = true;
			// 
			// clmEdit
			// 
			this.clmEdit.HeaderText = "Editar";
			this.clmEdit.Name = "clmEdit";
			this.clmEdit.ReadOnly = true;
			this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.clmEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// clmDelete
			// 
			this.clmDelete.HeaderText = "Eliminar";
			this.clmDelete.Name = "clmDelete";
			this.clmDelete.ReadOnly = true;
			this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.clmDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// NewUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 297);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.clbPermissions);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NewUsers";
			this.Text = "Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.CheckedListBox clbPermissions;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
		private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
		private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
	}
}