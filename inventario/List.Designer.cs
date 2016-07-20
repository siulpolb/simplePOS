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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clmPrice,
            this.clmBuyPrice});
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 0);
			this.dgvList.Name = "dgvList";
			this.dgvList.Size = new System.Drawing.Size(858, 322);
			this.dgvList.TabIndex = 0;
			// 
			// clmId
			// 
			dataGridViewCellStyle1.Format = "000000";
			dataGridViewCellStyle1.NullValue = null;
			this.clmId.DefaultCellStyle = dataGridViewCellStyle1;
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
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.clmMinimum.DefaultCellStyle = dataGridViewCellStyle2;
			this.clmMinimum.HeaderText = "Stock Minimo";
			this.clmMinimum.Name = "clmMinimum";
			this.clmMinimum.ReadOnly = true;
			// 
			// clmStock
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.clmStock.DefaultCellStyle = dataGridViewCellStyle3;
			this.clmStock.HeaderText = "Stock";
			this.clmStock.Name = "clmStock";
			this.clmStock.ReadOnly = true;
			// 
			// clmPrice
			// 
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.clmPrice.DefaultCellStyle = dataGridViewCellStyle4;
			this.clmPrice.HeaderText = "Precio Venta";
			this.clmPrice.Name = "clmPrice";
			this.clmPrice.ReadOnly = true;
			// 
			// clmBuyPrice
			// 
			dataGridViewCellStyle5.Format = "C2";
			dataGridViewCellStyle5.NullValue = null;
			this.clmBuyPrice.DefaultCellStyle = dataGridViewCellStyle5;
			this.clmBuyPrice.HeaderText = "Precio Compra";
			this.clmBuyPrice.Name = "clmBuyPrice";
			this.clmBuyPrice.ReadOnly = true;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn clmBuyPrice;
	}
}