﻿using System;
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
    public partial class ReportModulePurchase : Form
    {
        public ReportModulePurchase()
        {
            InitializeComponent();
        }

        private void dataGridViewReportPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewReportPurchase.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}