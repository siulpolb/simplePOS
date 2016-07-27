﻿namespace inventario
{
    partial class Entradas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.dgvBuy = new System.Windows.Forms.DataGridView();
			this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnBuy = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
			this.SuspendLayout();
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(12, 46);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(398, 20);
			this.tbProductName.TabIndex = 1;
			this.tbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
			// 
			// dgvBuy
			// 
			this.dgvBuy.AllowUserToAddRows = false;
			this.dgvBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmUnit,
            this.clmCantidad,
            this.clmUnitPrice,
            this.clmTotalPrice});
			this.dgvBuy.Location = new System.Drawing.Point(12, 97);
			this.dgvBuy.Name = "dgvBuy";
			this.dgvBuy.Size = new System.Drawing.Size(813, 241);
			this.dgvBuy.TabIndex = 3;
			this.dgvBuy.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellEndEdit);
			this.dgvBuy.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSell_UserDeletingRow);
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
			// clmCantidad
			// 
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.clmCantidad.DefaultCellStyle = dataGridViewCellStyle2;
			this.clmCantidad.HeaderText = "Cantidad";
			this.clmCantidad.Name = "clmCantidad";
			// 
			// clmUnitPrice
			// 
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.clmUnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
			this.clmUnitPrice.HeaderText = "Precio Unitario";
			this.clmUnitPrice.Name = "clmUnitPrice";
			// 
			// clmTotalPrice
			// 
			dataGridViewCellStyle4.Format = "C2";
			dataGridViewCellStyle4.NullValue = null;
			this.clmTotalPrice.DefaultCellStyle = dataGridViewCellStyle4;
			this.clmTotalPrice.HeaderText = "Total";
			this.clmTotalPrice.Name = "clmTotalPrice";
			this.clmTotalPrice.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(416, 44);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.Location = new System.Drawing.Point(530, 44);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(106, 29);
			this.lbTotal.TabIndex = 4;
			this.lbTotal.Text = "Total: $0";
			// 
			// btnBuy
			// 
			this.btnBuy.Location = new System.Drawing.Point(750, 44);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(75, 23);
			this.btnBuy.TabIndex = 5;
			this.btnBuy.Text = "Compra";
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// Entradas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 350);
			this.Controls.Add(this.btnBuy);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvBuy);
			this.Controls.Add(this.tbProductName);
			this.Name = "Entradas";
			this.Text = "Entradas";
			this.Load += new System.EventHandler(this.Entradas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
	}
}

