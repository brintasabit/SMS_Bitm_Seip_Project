using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class SalesModule : Form
    {
        public SalesModule()
        {
            InitializeComponent();
        }

        private void SalesModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet2.Sales' table. You can move, or remove it, as needed.
           // this.salesTableAdapter.Fill(this.stockManagementSystemDataSet2.Sales);

        }

        private void dataGridViewSales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSales.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
