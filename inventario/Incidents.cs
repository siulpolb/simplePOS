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
		List<Log> logs;

		public Incidents(DB db)
		{
			InitializeComponent();
			this.db = db;
			btnWeek.PerformClick();
			dtpFrom.Value = DateTime.Now;
			dtpTo.Value = DateTime.Now.AddDays(1);
		}

		public void fillIncidents()
		{
			dgvIncidents.Rows.Clear();
			foreach (Log l in logs)
				dgvIncidents.Rows.Add(l.toObjectArray());
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			logs = db.getAllLogs();
			fillIncidents();
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			logs = db.getLogsDates(DateTime.Now.AddMonths(-1), DateTime.Now);
			fillIncidents();
		}

		private void btnWeek_Click(object sender, EventArgs e)
		{
			logs = db.getLogsDates(DateTime.Now.AddDays(-7), DateTime.Now);
			fillIncidents();
		}

		private void dtpFrom_ValueChanged(object sender, EventArgs e)
		{
			DateTime fromValue = dtpFrom.Value;
			dtpTo.MinDate = fromValue.AddDays(1);
			dtpTo.Value = fromValue.AddDays(1);
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			logs = db.getLogsDates(DateTime.Now, DateTime.Now);
			fillIncidents();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			logs = db.getLogsDates(dtpFrom.Value, dtpTo.Value);
			fillIncidents();
		}
	}
}
