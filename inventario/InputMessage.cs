using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
	public partial class InputMessage : Form
	{

		public string Message { get; set; }

		public InputMessage(string title, string message)
		{
			InitializeComponent();
			this.Text = title;
			lbMessage.Text = message;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Message = tbInput.Text;
			this.Close();
		}
	}
}
