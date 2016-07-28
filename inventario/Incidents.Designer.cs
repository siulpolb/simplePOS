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
			this.dgvIncidents.TabIndex = 0;
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
			// Incidents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 313);
			this.Controls.Add(this.dgvIncidents);
			this.Name = "Incidents";
			this.Text = "Incidentes";
			((System.ComponentModel.ISupportInitialize)(this.dgvIncidents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvIncidents;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmIncident;
	}
}