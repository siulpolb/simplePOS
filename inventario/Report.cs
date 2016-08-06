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
	public partial class Report : Form
	{
		DB db;
		List<Sale> sales;
		List<Sale> incomes;
		double totalSales = 0;
		double totalIncome = 0;
		double total = 0;

		public Report(DB db)
		{
			InitializeComponent();
			this.db = db;
			dtpFrom.Value = DateTime.Now;
			sales = db.getSales(DateTime.Now.AddDays(-7), DateTime.Now);
			incomes = db.getIncomes(DateTime.Now.AddDays(-7), DateTime.Now);
			fillData();
		}

		private void dtpFrom_ValueChanged(object sender, EventArgs e)
		{
			DateTime fromValue = dtpFrom.Value;
			dtpTo.MinDate = fromValue.AddDays(1);
			dtpTo.Value = fromValue.AddDays(1);
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			sales = db.getAllSales();
			incomes = db.getAllIncomes();
			fillData();
		}

		public void fillData()
		{
			totalSales = 0;
			totalIncome = 0;
			total = 0;
			dgvEntradas.Rows.Clear();
			dgvVentas.Rows.Clear();
			foreach (Sale s in sales)
			{
				dgvVentas.Rows.Add(s.ToObjectArray());
				totalSales += s.getTotal();
			}
			foreach (Sale i in incomes)
			{
				dgvEntradas.Rows.Add(i.ToObjectArray());
				totalIncome += i.getTotal();
			}
			total = totalSales - totalIncome;
			lbVentas.Text = "Ventas: $"+totalSales;
			lbEntradas.Text = "Entradas: $" + totalIncome;
			lbTotal.Text = "Total: $" + total;
		}

		private void btnMonth_Click(object sender, EventArgs e)
		{
			sales = db.getSales(DateTime.Now.AddMonths(-1), DateTime.Now);
			incomes = db.getIncomes(DateTime.Now.AddMonths(-1), DateTime.Now);
			fillData();
		}

		private void btnWeek_Click(object sender, EventArgs e)
		{
			sales = db.getSales(DateTime.Now.AddDays(-7), DateTime.Now);
			incomes = db.getIncomes(DateTime.Now.AddDays(-7), DateTime.Now);
			fillData();
		}

		private void btnToday_Click(object sender, EventArgs e)
		{
			sales = db.getSales(DateTime.Today, DateTime.Now);
			incomes = db.getIncomes(DateTime.Today, DateTime.Now);
			fillData();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			sales = db.getSales(dtpFrom.Value, dtpTo.Value);
			incomes = db.getIncomes(dtpFrom.Value, dtpTo.Value);
			fillData();
		}
	}
}
