namespace inventario
{
	partial class Resgistar
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbUnit = new System.Windows.Forms.TextBox();
			this.tbMinimum = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(89, 12);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(194, 20);
			this.tbName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Unidad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Stock Minimo";
			// 
			// tbUnit
			// 
			this.tbUnit.Location = new System.Drawing.Point(89, 53);
			this.tbUnit.Name = "tbUnit";
			this.tbUnit.Size = new System.Drawing.Size(194, 20);
			this.tbUnit.TabIndex = 4;
			// 
			// tbMinimum
			// 
			this.tbMinimum.Location = new System.Drawing.Point(89, 89);
			this.tbMinimum.Name = "tbMinimum";
			this.tbMinimum.Size = new System.Drawing.Size(194, 20);
			this.tbMinimum.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tipo";
			// 
			// cbType
			// 
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(89, 128);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(194, 21);
			this.cbType.TabIndex = 7;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(112, 177);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// Resgistar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 244);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cbType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbMinimum);
			this.Controls.Add(this.tbUnit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbName);
			this.Name = "Resgistar";
			this.Text = "Nuevo Producto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUnit;
		private System.Windows.Forms.TextBox tbMinimum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Button btnAdd;
	}
}