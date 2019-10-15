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
    public partial class PartyModuleSupplier : Form
    {
        public PartyModuleSupplier()
        {
            InitializeComponent();
        }

        private void dataGridViewSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
