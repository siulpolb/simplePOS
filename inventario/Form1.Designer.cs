namespace inventario
{
    partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.dgvSell = new System.Windows.Forms.DataGridView();
			this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmObservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnSell = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(837, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inventarioToolStripMenuItem
			// 
			this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.entradasToolStripMenuItem});
			this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
			this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.inventarioToolStripMenuItem.Text = "Inventario";
			// 
			// verToolStripMenuItem
			// 
			this.verToolStripMenuItem.Name = "verToolStripMenuItem";
			this.verToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.verToolStripMenuItem.Text = "Ver";
			// 
			// entradasToolStripMenuItem
			// 
			this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
			this.entradasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.entradasToolStripMenuItem.Text = "Entradas";
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(12, 46);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(398, 20);
			this.tbProductName.TabIndex = 1;
			this.tbProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyDown);
			// 
			// dgvSell
			// 
			this.dgvSell.AllowUserToAddRows = false;
			this.dgvSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmUnit,
            this.clmCantidad,
            this.clmUnitPrice,
            this.clmTotalPrice,
            this.clmObservations});
			this.dgvSell.Location = new System.Drawing.Point(12, 97);
			this.dgvSell.Name = "dgvSell";
			this.dgvSell.Size = new System.Drawing.Size(813, 241);
			this.dgvSell.TabIndex = 3;
			this.dgvSell.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellEndEdit);
			// 
			// clmId
			// 
			dataGridViewCellStyle4.Format = "000000";
			dataGridViewCellStyle4.NullValue = null;
			this.clmId.DefaultCellStyle = dataGridViewCellStyle4;
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
			this.clmCantidad.HeaderText = "Cantidad";
			this.clmCantidad.Name = "clmCantidad";
			// 
			// clmUnitPrice
			// 
			this.clmUnitPrice.HeaderText = "Precio Unitario";
			this.clmUnitPrice.Name = "clmUnitPrice";
			this.clmUnitPrice.ReadOnly = true;
			// 
			// clmTotalPrice
			// 
			this.clmTotalPrice.HeaderText = "Total";
			this.clmTotalPrice.Name = "clmTotalPrice";
			this.clmTotalPrice.ReadOnly = true;
			// 
			// clmObservations
			// 
			this.clmObservations.HeaderText = "Observaciones";
			this.clmObservations.Name = "clmObservations";
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
			// btnSell
			// 
			this.btnSell.Location = new System.Drawing.Point(750, 44);
			this.btnSell.Name = "btnSell";
			this.btnSell.Size = new System.Drawing.Size(75, 23);
			this.btnSell.TabIndex = 5;
			this.btnSell.Text = "Venta";
			this.btnSell.UseVisualStyleBackColor = true;
			this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 350);
			this.Controls.Add(this.btnSell);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvSell);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Inventario";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmObservations;
		private System.Windows.Forms.Button btnSell;
	}
}

