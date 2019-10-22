using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Bill;
using StockManagementSystem.Model;
namespace StockManagementSystem
{
    public partial class ReportModuleSales : Form
    {
        ReportSalesManager _reportSalesManager=new ReportSalesManager();
        ReportSales _reportSales=new ReportSales();
        public ReportModuleSales()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewReportSales.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
