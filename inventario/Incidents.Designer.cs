namespace inventario
{
	partial class Incidents
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
			this.dgvIncidents = new System.Windows.Forms.DataGridView();
			this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmIncident = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnWeek = new System.Windows.Forms.Button();
			this.btnMonth = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.btnToday = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.btnShow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvIncidents
			// 
			this.dgvIncidents.AllowUserToAddRows = false;
			this.dgvIncidents.AllowUserToDeleteRows = false;
			this.dgvIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIncidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmTime,
            this.clmUser,
            this.clmIncident});
			this.dgvIncidents.Location = new System.Drawing.Point(12, 81);
			this.dgvIncidents.Name = "dgvIncidents";
			this.dgvIncidents.ReadOnly = true;
			this.dgvIncidents.Size = new System.Drawing.Size(797, 220);
			this.dgvIncidents.TabIndex = 40;
			// 
			// clmDate
			// 
			this.clmDate.HeaderText = "Fecha";
			this.clmDate.Name = "clmDate";
			this.clmDate.ReadOnly = true;
			// 
			// clmTime
			// 
			this.clmTime.HeaderText = "Hora";
			this.clmTime.Name = "clmTime";
			this.clmTime.ReadOnly = true;
			// 
			// clmUser
			// 
			this.clmUser.HeaderText = "Usuario";
			this.clmUser.Name = "clmUser";
			this.clmUser.ReadOnly = true;
			// 
			// clmIncident
			// 
			this.clmIncident.HeaderText = "Incidente";
			this.clmIncident.Name = "clmIncident";
			this.clmIncident.ReadOnly = true;
			// 
			// btnWeek
			// 
			this.btnWeek.Location = new System.Drawing.Point(12, 41);
			this.btnWeek.Name = "btnWeek";
			this.btnWeek.Size = new System.Drawing.Size(153, 23);
			this.btnWeek.TabIndex = 1;
			this.btnWeek.Text = "Esta Semana";
			this.btnWeek.UseVisualStyleBackColor = true;
			this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
			// 
			// btnMonth
			// 
			this.btnMonth.Location = new System.Drawing.Point(171, 12);
			this.btnMonth.Name = "btnMonth";
			this.btnMonth.Size = new System.Drawing.Size(153, 23);
			this.btnMonth.TabIndex = 2;
			this.btnMonth.Text = "Este Mes";
			this.btnMonth.UseVisualStyleBackColor = true;
			this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(171, 41);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(153, 23);
			this.btnAll.TabIndex = 3;
			this.btnAll.Text = "Todos";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// btnToday
			// 
			this.btnToday.Location = new System.Drawing.Point(12, 12);
			this.btnToday.Name = "btnToday";
			this.btnToday.Size = new System.Drawing.Size(153, 23);
			this.btnToday.TabIndex = 0;
			this.btnToday.Text = "Hoy";
			this.btnToday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnToday.UseVisualStyleBackColor = true;
			this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(357, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = "De:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(387, 15);
			this.dtpFrom.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(200, 20);
			this.dtpFrom.TabIndex = 4;
			this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(365, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 43;
			this.label2.Text = "a:";
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(387, 45);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(200, 20);
			this.dtpTo.TabIndex = 5;
			// 
			// btnShow
			// 
			this.btnShow.Location = new System.Drawing.Point(593, 31);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(153, 23);
			this.btnShow.TabIndex = 6;
			this.btnShow.Text = "Mostrar";
			this.btnShow.UseVisualStyleBackColor = true;
			this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
			// 
			// Incidents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 313);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnToday);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnMonth);
			this.Controls.Add(this.btnWeek);
			this.Controls.Add(this.dgvIncidents);
			this.Name = "Incidents";
			this.Text = "Incidentes";
			((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvIncidents;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncident;
		private System.Windows.Forms.Button btnWeek;
		private System.Windows.Forms.Button btnMonth;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnToday;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.Button btnShow;
	}
}