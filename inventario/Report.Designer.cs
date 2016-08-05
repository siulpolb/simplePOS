namespace inventario
{
	partial class Report
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbVentas = new System.Windows.Forms.Label();
			this.lbEntradas = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnShow = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnToday = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnMonth = new System.Windows.Forms.Button();
			this.btnWeek = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.dgvEntradas = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.clmSellFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmSellHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmSellUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmSellItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmSellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomeFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomeHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncomePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
			this.SuspendLayout();
			// 
			// lbVentas
			// 
			this.lbVentas.AutoSize = true;
			this.lbVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbVentas.Location = new System.Drawing.Point(12, 25);
			this.lbVentas.Name = "lbVentas";
			this.lbVentas.Size = new System.Drawing.Size(64, 20);
			this.lbVentas.TabIndex = 0;
			this.lbVentas.Text = "Ventas:";
			// 
			// lbEntradas
			// 
			this.lbEntradas.AutoSize = true;
			this.lbEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEntradas.Location = new System.Drawing.Point(266, 25);
			this.lbEntradas.Name = "lbEntradas";
			this.lbEntradas.Size = new System.Drawing.Size(78, 20);
			this.lbEntradas.TabIndex = 1;
			this.lbEntradas.Text = "Entradas:";
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.Location = new System.Drawing.Point(541, 25);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(48, 20);
			this.lbTotal.TabIndex = 2;
			this.lbTotal.Text = "Total:";
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(595, 90);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(153, 23);
			this.btnShow.TabIndex = 50;
			this.btnShow.Text = "Mostrar";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(389, 104);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(200, 20);
			this.dtpTo.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(367, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 13);
			this.label4.TabIndex = 52;
			this.label4.Text = "a:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(389, 74);
			this.dtpFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(200, 20);
			this.dtpFrom.TabIndex = 48;
			this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(359, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 51;
			this.label5.Text = "De:";
			// 
			// btnToday
			// 
			this.btnToday.Location = new System.Drawing.Point(14, 71);
			this.btnToday.Name = "btnToday";
			this.btnToday.Size = new System.Drawing.Size(153, 23);
			this.btnToday.TabIndex = 44;
			this.btnToday.Text = "Hoy";
			this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnToday.UseVisualStyleBackColor = true;
			this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(173, 100);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(153, 23);
			this.btnAll.TabIndex = 47;
			this.btnAll.Text = "Todos";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.Location = new System.Drawing.Point(173, 71);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Size = new System.Drawing.Size(153, 23);
			this.btnMonth.TabIndex = 46;
			this.btnMonth.Text = "Este Mes";
			this.btnMonth.UseVisualStyleBackColor = true;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// btnWeek
			// 
			this.btnWeek.Location = new System.Drawing.Point(14, 100);
			this.btnWeek.Name = "btnWeek";
			this.btnWeek.Size = new System.Drawing.Size(153, 23);
			this.btnWeek.TabIndex = 45;
			this.btnWeek.Text = "Esta Semana";
			this.btnWeek.UseVisualStyleBackColor = true;
			this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Ventas:";
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToAddRows = false;
			this.dgvVentas.AllowUserToDeleteRows = false;
			this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSellFecha,
            this.clmSellHora,
            this.clmSellUser,
            this.clmSellItem,
            this.clmSellQuantity,
            this.clmSellPrice});
			this.dgvVentas.Location = new System.Drawing.Point(12, 180);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.ReadOnly = true;
			this.dgvVentas.Size = new System.Drawing.Size(771, 150);
			this.dgvVentas.TabIndex = 54;
			// 
			// dgvEntradas
			// 
			this.dgvEntradas.AllowUserToAddRows = false;
			this.dgvEntradas.AllowUserToDeleteRows = false;
			this.dgvEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIncomeFecha,
            this.clmIncomeHora,
            this.clmIncomeUser,
            this.clmIncomeItem,
            this.clmIncomeQuantity,
            this.clmIncomePrice});
			this.dgvEntradas.Location = new System.Drawing.Point(12, 367);
			this.dgvEntradas.Name = "dgvEntradas";
			this.dgvEntradas.ReadOnly = true;
			this.dgvEntradas.Size = new System.Drawing.Size(771, 150);
			this.dgvEntradas.TabIndex = 56;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 351);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 13);
			this.label7.TabIndex = 55;
			this.label7.Text = "Entradas:";
			// 
			// clmSellFecha
			// 
			this.clmSellFecha.HeaderText = "Fecha";
			this.clmSellFecha.Name = "clmSellFecha";
			this.clmSellFecha.ReadOnly = true;
			// 
			// clmSellHora
			// 
			this.clmSellHora.HeaderText = "Hora";
			this.clmSellHora.Name = "clmSellHora";
			this.clmSellHora.ReadOnly = true;
			// 
			// clmSellUser
			// 
			this.clmSellUser.HeaderText = "Usuario";
			this.clmSellUser.Name = "clmSellUser";
			this.clmSellUser.ReadOnly = true;
			// 
			// clmSellItem
			// 
			this.clmSellItem.HeaderText = "Producto";
			this.clmSellItem.Name = "clmSellItem";
			this.clmSellItem.ReadOnly = true;
			// 
			// clmSellQuantity
			// 
			dataGridViewCellStyle17.Format = "N2";
			dataGridViewCellStyle17.NullValue = null;
			this.clmSellQuantity.DefaultCellStyle = dataGridViewCellStyle17;
			this.clmSellQuantity.HeaderText = "Cantidad";
			this.clmSellQuantity.Name = "clmSellQuantity";
			this.clmSellQuantity.ReadOnly = true;
			// 
			// clmSellPrice
			// 
			dataGridViewCellStyle18.Format = "C2";
			dataGridViewCellStyle18.NullValue = null;
			this.clmSellPrice.DefaultCellStyle = dataGridViewCellStyle18;
			this.clmSellPrice.HeaderText = "Precio";
			this.clmSellPrice.Name = "clmSellPrice";
			this.clmSellPrice.ReadOnly = true;
			// 
			// clmIncomeFecha
			// 
			this.clmIncomeFecha.HeaderText = "Fecha";
			this.clmIncomeFecha.Name = "clmIncomeFecha";
			this.clmIncomeFecha.ReadOnly = true;
			// 
			// clmIncomeHora
			// 
			this.clmIncomeHora.HeaderText = "Hora";
			this.clmIncomeHora.Name = "clmIncomeHora";
			this.clmIncomeHora.ReadOnly = true;
			// 
			// clmIncomeUser
			// 
			this.clmIncomeUser.HeaderText = "Usuario";
			this.clmIncomeUser.Name = "clmIncomeUser";
			this.clmIncomeUser.ReadOnly = true;
			// 
			// clmIncomeItem
			// 
			this.clmIncomeItem.HeaderText = "Producto";
			this.clmIncomeItem.Name = "clmIncomeItem";
			this.clmIncomeItem.ReadOnly = true;
			// 
			// clmIncomeQuantity
			// 
			dataGridViewCellStyle19.Format = "N2";
			dataGridViewCellStyle19.NullValue = null;
			this.clmIncomeQuantity.DefaultCellStyle = dataGridViewCellStyle19;
			this.clmIncomeQuantity.HeaderText = "Cantidad";
			this.clmIncomeQuantity.Name = "clmIncomeQuantity";
			this.clmIncomeQuantity.ReadOnly = true;
			// 
			// clmIncomePrice
			// 
			dataGridViewCellStyle20.Format = "C2";
			dataGridViewCellStyle20.NullValue = null;
			this.clmIncomePrice.DefaultCellStyle = dataGridViewCellStyle20;
			this.clmIncomePrice.HeaderText = "Precio";
			this.clmIncomePrice.Name = "clmIncomePrice";
			this.clmIncomePrice.ReadOnly = true;
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 529);
			this.Controls.Add(this.dgvEntradas);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnToday);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnWeek);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.lbEntradas);
			this.Controls.Add(this.lbVentas);
			this.Name = "Report";
			this.Text = "Reporte";
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbVentas;
		private System.Windows.Forms.Label lbEntradas;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnToday;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnMonth;
		private System.Windows.Forms.Button btnWeek;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.DataGridView dgvEntradas;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellHora;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmSellPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomeFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomeHora;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomeUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomeItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomeQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncomePrice;
	}
}