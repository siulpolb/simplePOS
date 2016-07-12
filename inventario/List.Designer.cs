namespace inventario
{
	partial class List
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
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvList
			// 
			this.dgvList.AllowUserToAddRows = false;
			this.dgvList.AllowUserToDeleteRows = false;
			this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmUnit,
            this.clmType,
            this.clmMinimum,
            this.clmStock,
            this.clmPrice});
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 0);
			this.dgvList.Name = "dgvList";
			this.dgvList.Size = new System.Drawing.Size(858, 322);
			this.dgvList.TabIndex = 0;
			// 
			// clmId
			// 
			this.clmId.HeaderText = "Código";
			this.clmId.Name = "clmId";
			this.clmId.ReadOnly = true;
			// 
			// clmName
			// 
			this.clmName.HeaderText = "Nombre";
			this.clmName.Name = "clmName";
			this.clmName.ReadOnly = true;
			// 
			// clmUnit
			// 
			this.clmUnit.HeaderText = "Unidad";
			this.clmUnit.Name = "clmUnit";
			this.clmUnit.ReadOnly = true;
			// 
			// clmType
			// 
			this.clmType.HeaderText = "Tipo";
			this.clmType.Name = "clmType";
			this.clmType.ReadOnly = true;
			// 
			// clmMinimum
			// 
			this.clmMinimum.HeaderText = "Stock Minimo";
			this.clmMinimum.Name = "clmMinimum";
			this.clmMinimum.ReadOnly = true;
			// 
			// clmStock
			// 
			this.clmStock.HeaderText = "Stock";
			this.clmStock.Name = "clmStock";
			this.clmStock.ReadOnly = true;
			// 
			// clmPrice
			// 
			this.clmPrice.HeaderText = "Precio";
			this.clmPrice.Name = "clmPrice";
			this.clmPrice.ReadOnly = true;
			// 
			// List
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 322);
			this.Controls.Add(this.dgvList);
			this.Name = "List";
			this.Text = "List";
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmMinimum;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
	}
}