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
	public partial class Incidents : Form
	{
		DB db;

		public Incidents(DB db)
		{
			InitializeComponent();
			this.db = db;
		}
	}
}
